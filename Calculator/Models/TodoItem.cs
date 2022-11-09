namespace Calculator.Models
{
    public class TodoItem
    {

        public string ID { get; set; }
        public string Expression { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public bool Done { get; set; }

        public static implicit operator List<object>(TodoItem v)
        {
            throw new NotImplementedException();
        }
    }
}
