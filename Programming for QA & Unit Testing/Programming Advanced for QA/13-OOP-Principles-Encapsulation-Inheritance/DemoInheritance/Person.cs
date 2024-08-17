namespace IntheritanceDemo
{
    //описваме всеки един човек
    public class Person
    {
        //характеристики
        private string name;
        private string address;

        public string Name { get; set; }
        public string Address { get; set; }

        //конструктор
        public Person (string name, string address)
        {
            //нов празен обект
            this.Name = name;
            this.Address = address;
        }

        //действия
        public void Talk (string text)
        {
            Console.WriteLine(this.Name + " says: " + text);
        }
        
    }
}



