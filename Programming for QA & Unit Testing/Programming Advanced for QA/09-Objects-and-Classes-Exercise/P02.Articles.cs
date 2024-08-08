namespace ProgrammingAdvancedForQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine().Split(", ");
            string title = article[0];
            string content = article[1];
            string author = article[2];

            Article newArticle = new Article(title, content, author);

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] commandData = Console.ReadLine().Split(": ");
                string cmd = commandData[0];
                string value = commandData[1];

                if (cmd == "Edit")
                {
                    newArticle.Edit(value);
                }
                else if (cmd == "ChangeAuthor")
                {
                    newArticle.ChangeAuthor(value);
                }
                else
                {
                    newArticle.Rename(value);
                }
            }

            Console.WriteLine(newArticle.ToString());
            
        }

        public class Article
        {
            public string Title { get; private set; }
            public string Content { get; private set; }
            public string Author { get; private set; }

            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public void Edit(string newContent)
            {
                Content = newContent;
            }

            public void ChangeAuthor(string newAuthor) 
            {
                Author = newAuthor;
            }

            public void Rename(string newTitle)
            {
                Title = newTitle;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
    }
}