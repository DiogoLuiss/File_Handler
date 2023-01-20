using System.Text;

 partial class Program
{

    static void HandlingFileRead()
    {
        var AddressFile = "contas.txt";
        int NumberBytesReader = -1;

        //Quando se utiliza o Using o objeto é excluido automaticamente da memoria, sem precisar usar um tipo func.Close(); economizando tempo e espaço
        //Ao abrir o arquivo se eu não usar o FlowFile.Close() o arquivo não pode ser alterado, porque está em uso, porem ao usar o using isso se perde na memoria então não preciso colocar o FlowFile.Close();

        using (var FlowFile = new FileStream(AddressFile, FileMode.Open)) //Acha e por assim dizer abre os arquivos 
        {
            var buffer = new byte[1024]; //Guardamos os valores em Byte

            while (NumberBytesReader != 0) //Quando realizamos a leitura, mesmo depois de executar ele continua de onde parou, caso o valor retorno 0 paramos a execução
            {
                NumberBytesReader = FlowFile.Read(buffer, 0, 1024); //Lê os arquivos e retorna valor em byte, detalhe que podemos aumentar a leitura de bytes, e automaticamente ele atualiza o valor do array
                                                                    //O retorno do NumberBytesReader trás quantos bytes foram lidos;
                Readfile(buffer, NumberBytesReader);
 
              
            }

        }

        Console.ReadKey();

    }

     static void  Readfile(byte[] File, int BytesRead)
    {
        var utf8 =  new UTF8Encoding(); //Para usar o UTF8 que por assim dizer Decodifica o byte

        //utf8.GetString(File,index: posição inicial, count até onde vai ler) 

        var text  = utf8.GetString(File, 0, BytesRead); //Decodifica em string

         Console.WriteLine($"{text}");
        Console.WriteLine($" Numero de bytes lidos {BytesRead}");

        //Array.Sort(File);

        //foreach (var item in File)
        //{
        //    Console.WriteLine(item);
        //}

    }


}