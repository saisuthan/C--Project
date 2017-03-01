using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KreationService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IKreationService
    {
        /* Login */
        [OperationContract]
        String login(Log login);



        


        // TODO: Add your service operations here


        /* Access */

        [OperationContract]
         int add_Ac(Log login);

        [OperationContract]
        void Deleteusername(String username);
        [OperationContract]
        void Searchusername(String username);
        /* Accounts */

        [OperationContract]
        int up_Acc(Accounts Accounts);
        [OperationContract]
        int ed_acc(Accounts Accounts);
        [OperationContract]
        DataSet accDetail(Accounts Account);

        /* Products */


        [OperationContract]
         int add_prod(Product product);
        [OperationContract]
         DataSet ProDetail(Product Product);

        [OperationContract]
        int ed_prod(Product Product);

        /* View */

        [OperationContract]
        DataSet SearchGuest_BranchBorella();

        [OperationContract]
        DataSet SearchGuest_BranchBamba();

        [OperationContract]
        DataSet SearchGuest_BranchWattala();

        [OperationContract]
        DataSet SearchUser();



        //POS 

        [OperationContract]
        int GetPrice(String ID);

        [OperationContract]
        String Name(String ID);

        [OperationContract]
        void InsertPos(Product product);

         [OperationContract]
        DataSet SearchAllProducts(String ID);

         [OperationContract]
         DataSet FillProducts(String invoiceNo);

         [OperationContract]
         String Get_Sum_of_Charges(String invoice);

         [OperationContract]
         void delete_pos();

         [OperationContract]
         List<Product> productlist(String invoiceno);

        [OperationContract]
        void delete_item(Product product);

        // Use a data contract as illustrated in the sample below to add composite types to service operations.
        // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "KreationService.ContractType".


    }
}