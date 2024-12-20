using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    //Whats Can We Write Inside The NameSpace?
    //1-Class
    //2-Struct(stands For Structure)
    //3-Interface
    //4-Enum
    //-----------------------------------------
    //Allowed Access Modifier Inside The Namespace
    //1-Internal(Default Access Modifer)
    //2-Public

    public class TypeA
    {
       /* private*/ int X;
        internal int Y;
        public int Z;
        #region Definitions
        //What You Can Weite Inside The Class Or Struct?
        //1-Attribute (Filed * Variable)
        //2-Property(FullProperty - Automatic Property - Indexer)
        //3-Funcation(Constructor - Getter/Setter - Method)
        //4-Events
        //-----------------------------------------
        //Allowed Access Modifier Insider The Struct
        //1-Private
        //2-Internal
        //3-Public
        //--------------------------------------------------
        //Allowed Access Modifers Inside The Class
        //1-Private
        //2-Protected
        //3-Internal
        //4-Internel Protected
        //5-Internal Protected
        //6-Public
        //-----------------------------------------
        //What You Can Write Inside The Interface
        //1- Signature For Property
        //2-Signature For Method
        //3-Default Implemented Method
        //-------------------------------------------------
        //Default Access Modifier  Insider The Interface is Public


        #endregion


    }
}
