using EF_EXAMPLE.Model.Context;
using EF_EXAMPLE.Repositories;
using EF_EXAMPLE.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_EXAMPLE
{
    public partial class Form1 : Form
    {
        private MyContext Context;

        private IUnitOfWork _MyUnitoW;
        private IRepository<People> _peopleRepository;
        private IRepository<Jobs> _jobsRepository;
        public Form1()
        {

            InitializeComponent();
            Context = new MyContext();
            _MyUnitoW = new UnitOfWorkEf(Context);
            _peopleRepository = new RepositoryEf<People>(Context);
            _jobsRepository = new RepositoryEf<Jobs>(Context);


            if (!Context.Database.Exists())
            {
                Context.Database.Create();

                try
                {
                    //Default olarak ilk iş kaydını yapıyoruz
                    Jobs jobs = new Jobs()
                    {
                        ID = 1,
                        JobName = "Software Engineer",

                    };
                    _jobsRepository.Add(jobs);

                    Jobs jobs1 = new Jobs()
                    {
                        JobName = "Computer Engineer",
                    };
                    _jobsRepository.Add(jobs1);

                    Jobs jobs2 = new Jobs()
                    {
                        JobName = "Doctor",
                    };
                    _jobsRepository.Add(jobs2);
                    Jobs jobs3 = new Jobs()
                    {
                        JobName = "Actor",
                    };
                    _jobsRepository.Add(jobs3);
                    Jobs jobs4 = new Jobs()
                    {
                        JobName = "Web Designer",
                    };
                    _jobsRepository.Add(jobs4);
                    Jobs jobs5 = new Jobs()
                    {
                        JobName = "Project Manager",
                    };
                    _jobsRepository.Add(jobs5);
                    Jobs jobs6 = new Jobs()
                    {
                        JobName = "Librarian",
                    };
                    _jobsRepository.Add(jobs6);
                    Jobs jobs7 = new Jobs()
                    {
                        JobName = "Astronaut",
                    };
                    _jobsRepository.Add(jobs7);
                    People people = new People()
                    {
                        ID = 1,
                        FirstName = "Raşit",
                        LastName = "Yılmaz",
                        JobsID=1,

                    };
                    _peopleRepository.Add(people);

                    _MyUnitoW.SaveChanges();

                }
                catch (Exception)
                {

                    throw;
                }
            }










        }


        private void ClearData()
        {
            name_textBox.Clear();
            surname_textBox.Clear();
            dataGridView_Jobs.ClearSelection();
            label_CurrentRowName.Text = "";
            label_CurrentRowSurname.Text = "";
            label_CurrentRowJobName.Text = "";
        }
        private void RefreshDataSource()
        {
            dataGridView_Peoples.DataSource = _peopleRepository.GetAll().Join(_jobsRepository.GetAll(), x => x.JobsID, y => y.ID, (x, y) => new { x.ID, x.FirstName, x.LastName, y.JobName }).ToList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text != "" || surname_textBox.Text != "")
            {
                People people = new People()
                {
                    FirstName = name_textBox.Text,
                    LastName = surname_textBox.Text,
                    JobsID = Convert.ToInt32(dataGridView_Jobs.CurrentRow.Cells[0].Value),

                };
                _peopleRepository.Add(people);
                _MyUnitoW.SaveChanges();
            }



            RefreshDataSource();

            ClearData();
        }


        private void update_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView_Peoples.CurrentRow != null)
            {

                int CurrentRowID = Convert.ToInt32(dataGridView_Peoples.CurrentRow.Cells[0].Value);

                People ModifiedPeople = _peopleRepository.GetAll().FirstOrDefault(X => X.ID == CurrentRowID);
                ModifiedPeople.FirstName = name_textBox.Text;
                ModifiedPeople.LastName = surname_textBox.Text;
                ModifiedPeople.JobsID = Convert.ToInt32(dataGridView_Jobs.CurrentRow.Cells[0].Value);
                _peopleRepository.Update(ModifiedPeople);
                _MyUnitoW.SaveChanges();
                RefreshDataSource();

                ClearData();

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CurrentRowID = Convert.ToInt32(dataGridView_Peoples.CurrentRow.Cells[0].Value);

            var PeopleData = _peopleRepository.GetById(CurrentRowID);

            name_textBox.Text = PeopleData.FirstName;
            surname_textBox.Text = PeopleData.LastName;
            dataGridView_Jobs.ClearSelection();

            dataGridView_Jobs.Rows[PeopleData.JobsID - 1].Selected = true;
            label_CurrentRowJobName.Text = dataGridView_Jobs.SelectedRows[0].Cells[1].Value.ToString();





        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView_Peoples.CurrentRow != null)
            {
                int CurrentRowID = Convert.ToInt32(dataGridView_Peoples.CurrentRow.Cells[0].Value);

                int counterid = Convert.ToInt32(dataGridView_Peoples.CurrentRow.Cells[0].Value);
                People RemovePeople = _peopleRepository.GetAll().FirstOrDefault(X => X.ID == CurrentRowID);
                _peopleRepository.Delete(RemovePeople);
                _MyUnitoW.SaveChanges();
                RefreshDataSource();

                ClearData();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            RefreshDataSource();

            dataGridView_Jobs.DataSource = _jobsRepository.GetAll().Select(x => new { x.ID, x.JobName }).ToList();
            dataGridView_Jobs.Columns[0].Width = 40;
            dataGridView_Jobs.Columns[1].Width = dataGridView_Jobs.Width - 60;
            dataGridView_Peoples.Columns[0].Width = 40;
            dataGridView_Peoples.Columns[1].Width = ((dataGridView_Peoples.Width - 50) / 3);
            dataGridView_Peoples.Columns[2].Width = ((dataGridView_Peoples.Width - 50) / 3);
            dataGridView_Peoples.Columns[3].Width = ((dataGridView_Peoples.Width - 50) / 3);



        }

        private void name_textBox_TextChanged(object sender, EventArgs e)
        {
            label_CurrentRowName.Text = name_textBox.Text;
            label_CurrentRowSurname.Text = surname_textBox.Text;

        }

        private void dataGridView_Jobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_CurrentRowJobName.Text = dataGridView_Jobs.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
