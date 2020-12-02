namespace Atributos_e_Métodos
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;

        public string Atacar(){
            return "Ataque corporal";
        }

        public string Defender(){
            return "Defesa executada";
        }
        
    }//FIM DO PERSONAGEM
}