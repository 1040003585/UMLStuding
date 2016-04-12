
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class OperationAdd : Operation {

    /**
     * 
     */
    public OperationAdd() {
    }

    /**
     * @return
     */
    public override double GetResult() {
        // TODO implement here
        return NumberA + NumberB;
    }

}