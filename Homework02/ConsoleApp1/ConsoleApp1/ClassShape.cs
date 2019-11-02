
namespace ClassShape
{
    class Shape  //Класс для примеров плейсхолдера R
    {
        public int num { get; set; }
        public  string name { get; private set; }
        public Shape(string name,int num)
        {
            this.name = name;
            this.num = num;
        }
    }
}
