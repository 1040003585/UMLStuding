
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class OperationFactory {

    /**
     * 
     */
    public OperationFactory() {
    }

    /**
     * @param operation 
     * @return
     */
    public static Operation createOperation(string operation) {
        // TODO implement here
        Operation oper = null;
        if (operation == "+")
        {
            oper = new OperationAdd();
        }
        return oper;
    }

}