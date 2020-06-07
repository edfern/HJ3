
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program {

    public Program() {
    }



    public static void Main(String[] args) {
        
    IPrint csv = new CsvIPrintDecorator(new TextoPlano());
    csv.print(args);
       
    }
}