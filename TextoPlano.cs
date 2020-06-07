
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class TextoPlano : IPrint {

    public TextoPlano() {
    }

    public void print(string[] archivo)
    {
        Console.WriteLine("\tTEXTO PLANO");
        for(int i=1; i<archivo.Length;i++){
            String fichero = archivo[i];
            String contenido = String.Empty;

            if (File.Exists(fichero))
            {
                contenido = File.ReadAllText(fichero);
                string[] lineas = contenido.Split(Environment.NewLine);
                foreach (string linea in lineas)
                {
                    Console.WriteLine(linea);
                }
            }
        }
	}
}