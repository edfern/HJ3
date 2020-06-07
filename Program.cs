
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program {

    public Program() {
    }

    /// <summary>
    /// @param args
    /// </summary>
    public static void Main(String[] args) {
        
        IPrintDecoratorFactory factory = new IPrintDecoratorFactory();
        factory.getIPrinterDecorator(args);

    }

}