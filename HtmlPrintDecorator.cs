using System;
using System.IO;
public class HtmlPrintDecorator : IPrintDecorator {

    public HtmlPrintDecorator(IPrint print):base(print) {
    }

    public override void print(string[] archivo){
        Console.WriteLine("\tCONVIRTIENDO");
        base.print(archivo);
        Console.WriteLine("\tA ARCHIVO HTML");
        for(int i=1;i<archivo.Length;i++){
            printHTML(archivo[i]);
        }      
    }
    public void printHTML(String archivo){
        String fichero = archivo;
        String contenido = String.Empty;
            if (File.Exists(fichero))
            {
                contenido = File.ReadAllText(fichero);
                string[] lineas = contenido.Split(Environment.NewLine);
                foreach (string linea in lineas)
                {
                    Console.WriteLine("<!DOCTYPE html>");
                    Console.WriteLine("<head>");
                    Console.WriteLine("     <title>"+archivo+"</title>");
                    Console.WriteLine("<body>\n     <div>\n     "+linea+"\n     </div>\n</body>");
                    Console.WriteLine("</head>\n");
            }
        }
    }

}