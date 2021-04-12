using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {
        string IJogador.Chuta()
        {
            return "Maradona estas pateando \n";
        }

        string IJogador.Corre()
        {
            return "Maradona estas corriendo \n";
        }

        string IJogador.Passe()
        {
            return "Maradona estas passando \n";
        }
    }
}