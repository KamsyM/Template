using NakedObjects;
using System.Linq;

namespace Template.Model
{
    public class Student
    {
        #region Injected Services
        //An implementation of this interface is injected automatically by the framework
        public IDomainObjectContainer Container { set; protected get; }
        #endregion

        //All persisted properties on a domain object must be 'virtual'

        [NakedObjectsIgnore]//Indicates that this property will never be seen in the UI
        public virtual int Id { get; set; }

        [Title]//This property will be used for the object's title at the top of the view and in a link
        public virtual string FullName { get; set; }

        public virtual int YearGroup { get; set; }

        public virtual Teacher Tutor { get; set; }

        public IQueryable<Teacher> AutoCompleteTutor(string matching)
        {
            return Container.Instances<Teacher>();
        }
        
        public void SendMessage(string text)
        {

        }

    }
}
