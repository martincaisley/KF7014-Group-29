using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public interface IUnitOfWork
    {
        /*
    * Method of implementing unit of work design pattern learned from:
    * https://codewithshadman.com/repository-pattern-csharp/
    * https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
    */
        IRepository<Appointment> appointment { get; }
        IRepository<Patient> patient { get; }
        IRepository<MedicalQuestionnaire> questionnaire { get; }
        void Save();
        void Dispose();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private IRepository<Appointment> _appointments;
        private IRepository<Patient> _patients;
        private IRepository<MedicalQuestionnaire> _questionnaire;
        private MyDBEntities context;

        public UnitOfWork (MyDBEntities context)
        {
            this.context = context;
        }

        public IRepository<Appointment> appointment
        {
            get
            {
                if (_appointments == null)
                {
                    _appointments = new Repository<Appointment>(context);
                }
                return _appointments;
            }
        }

        public IRepository<MedicalQuestionnaire> questionnaire
        {
            get
            {
                if (_questionnaire == null)
                {
                    _questionnaire = new Repository<MedicalQuestionnaire>(context);
                }
                return _questionnaire;
            }
        }
        public IRepository<Patient> patient 
        {
            get
            {
                if(_patients == null)
                {
                    _patients = new Repository<Patient>(context);
                }
                return _patients;
            }
        }

        public void Save()
        {
            context.SaveChanges();   
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
    
}
