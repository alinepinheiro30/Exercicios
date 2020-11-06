namespace One
{
    public class SegundaAtividade
    {
        public double NFinal { get; set; }                

        public string RetornaMedia(int prova, int projeto, int exercicios, int softwaresLivres)
        {
            var result = string.Empty;

            var media = CalculaMedia(prova,projeto,exercicios,softwaresLivres);
            
            result = media>=8?"Aprovado":"Final";
            
            if(result.Equals("Final"))
            {
                NFinal = 10 - media;
                result = "O aluno necessita de " + NFinal + " para ser aprovado.";
            }

            return result;
        }

        private double CalculaMedia(int prova, int projeto, int exercicios, int softwaresLivres)
        {
            return (prova*3)+(projeto*3)+(exercicios*2)+(softwaresLivres*3)/6;
        }    


    }


}
