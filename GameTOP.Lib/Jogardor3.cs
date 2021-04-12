using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogardor3 : IJogador
    {
        public string Chuta()
        {
            return "teste chuta";
        }

        public string Corre()
        {
            return "teste corre";
        }

        public string Passe()
        {
            return "teste passe";
        }
    }
}