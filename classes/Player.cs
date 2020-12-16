namespace _Polimorfismo_Override.classes
{
    public class Player
    {
        private float velocidade;

        private float forcaPulo;


        public virtual string Correr(){

            return "Correr = (x10)";

        }

        public virtual string Pular(){

            return "Pular = (x10)";

        }
    }
}