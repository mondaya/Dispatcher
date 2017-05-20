namespace Dispatcher.Models
{
    public class Load : BaseEntity
    {
        public int loadTypeId; 
        public LoadType loadType; 
        public LoadSource loadSource;
        public LoadDestination LoadDestination;
        public LoadAssignment loadAssigment;
        public LoadStatus loadStatus;
        public float rate;
    }
}