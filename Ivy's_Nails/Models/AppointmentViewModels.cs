namespace IvysNails.Models
{
    public class AppointmentViewModels
    {
        private object id;
        private object id1;
        private object topic;
        private object lecturer;
        private object id2;
        private object dateAndTime;
        private object userName;

        public AppointmentViewModels(int id, DateTime date, int serviceId)
        {
            Id = id;
            Date = date;
            ServiceId = serviceId;
            
        }

        public AppointmentViewModels(object id1, object topic, object lecturer, object id2, object dateAndTime, object userName)
        {
            this.id1 = id1;
            this.topic = topic;
            this.lecturer = lecturer;
            this.id2 = id2;
            this.dateAndTime = dateAndTime;
            this.userName = userName;
        }

        public int Id { get; set; }

        public DateTime Date { get; set; }

        public int ServiceId { get; set; }

    }
}
