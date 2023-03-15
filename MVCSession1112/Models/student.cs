namespace MVCSession1112.Models
{
    public /*static*/ class student
    {
        public static student std = null;
        public /*static*/ int Id { get; set; }

        private student()
        {

        }

        public static student getInstance()
        {
            
            if (std ==null) { 
            std = new student();
            return std;
            }
            else
            {
                return std;
            }
        }

    }
}
