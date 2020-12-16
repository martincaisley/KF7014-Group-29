using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public interface IUnitOfWork
    {
        Repository<Appointment> appointment { get; }
        Repository<Patient> patient { get; }
        void Save();
    }
    class UnitOfWork : IUnitOfWork
    {
        private Repository<Appointment> _appointments;
        private Repository<Patient> _patients;
        private MyDBEntities context;

        public UnitOfWork (MyDBEntities context)
        {
            this.context = context;
        }

        public Repository<Appointment> appointment
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
        public Repository<Patient> patient 
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
    }
    
}
