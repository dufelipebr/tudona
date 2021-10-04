using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TudoNaStoreEntity;
using System.Data.SqlClient;
using System.Data;


namespace TudoNaStoreDAO
{
    public static class OurProductDAO
    {
        private static string ENTITY = "OurProducts";
        private static string DEFAULTSTATUS = "Active";

        public static void InsertOurProduct(OurProductEntity obj, int clientID)
        {
            //get the default status for entity 
            List < EntityGenericModal > statuses = GenericDAO.GetEntityStatusValues(ENTITY);
            EntityGenericModal foundstatus = statuses.Find(x => x.Name == DEFAULTSTATUS);

            //get maxorder 
            SqlCommand cmdGetMaxOrder = new SqlCommand("select max(orderedBy) from OurProducts where clientID = @clientID");
            cmdGetMaxOrder.Parameters.Add(new SqlParameter("@clientID", clientID));
            int MaxSortOrderByOrderProductId = BaseConn.ExecuteScalar(cmdGetMaxOrder);
            MaxSortOrderByOrderProductId++;


            //insert DAO
            SqlCommand sql = new SqlCommand(@"INSERT INTO [dbo].[OurProducts] (clientID,productName,productDescription,
                thumbName,orderedBy,entityName,entityStatusID,CreationDate,LastModified,FileExtension,fileLenght,relativePath) 
            VALUES (@clientID,@productName,@productDescription,
                @thumbName,@orderedBy,@entityName,@entityStatusID,@CreationDate,@LastModified,@FileExtension,@fileLenght,@relativePath)");

            sql.Parameters.Add(new SqlParameter("@clientID", clientID));
            sql.Parameters.Add(new SqlParameter("@productName", obj.ProductName));
            sql.Parameters.Add(new SqlParameter("@productDescription", obj.Description));
            sql.Parameters.Add(new SqlParameter("@thumbName", obj.Thumb));
            sql.Parameters.Add(new SqlParameter("@orderedBy", MaxSortOrderByOrderProductId));
            sql.Parameters.Add(new SqlParameter("@entityName", ENTITY));
            sql.Parameters.Add(new SqlParameter("@entityStatusID", (foundstatus != null ? foundstatus.Key : "0")));
            sql.Parameters.Add(new SqlParameter("@CreationDate", DateTime.Now));
            sql.Parameters.Add(new SqlParameter("@LastModified", DateTime.Now));
            sql.Parameters.Add(new SqlParameter("@FileExtension", obj.Extension));
            sql.Parameters.Add(new SqlParameter("@fileLenght", obj.FileLenght));
            sql.Parameters.Add(new SqlParameter("@relativePath", obj.RelativePath));
            BaseConn.ExecuteNonQuery(sql);

            
        }

        public static void UpdateOurProductSort(OurProductEntity op)
        {
            SqlCommand sql = new SqlCommand(@"Update [dbo].[OurProducts]  set orderedBy =  @orderedBy where OurProductID = @OurProductID ");

            sql.Parameters.Add(new SqlParameter("@OurProductID", op.OurProductID));
            sql.Parameters.Add(new SqlParameter("@orderedBy", op.SortOrder));

            BaseConn.ExecuteNonQuery(sql);
        }

        public static List<OurProductEntity> GetOurProductList(int clientId)
        {
            List<OurProductEntity> lstOurProduct = new List<OurProductEntity>();

            SqlCommand sql = new SqlCommand("Select * from [dbo].[OurProducts] where clientID = @clientID order by orderedBy");
            sql.Parameters.Add(new SqlParameter("@clientID", clientId));

            DataTable dt = BaseConn.ExecuteQuery(sql);
            foreach(DataRow rd in dt.Rows)
            {
                lstOurProduct.Add(FillDt(rd));
            }
            return lstOurProduct;
        }

        public static OurProductEntity GetOurProduct(int OurProductID)
        {
            OurProductEntity et = new OurProductEntity();
            SqlCommand sql = new SqlCommand("Select * from [dbo].[OurProducts] where OurProductID = " + OurProductID.ToString());
            DataTable dt = BaseConn.ExecuteQuery(sql);
            foreach (DataRow rd in dt.Rows)
            {
                et = FillDt(rd);

            }
            return et;
        }

        private static OurProductEntity FillDt(DataRow rd)
        {
            OurProductEntity et = new OurProductEntity();
            et.OurProductID = Convert.ToInt32(rd["OurProductID"]);
            et.ProductName = rd["productName"].ToString();
            et.Description = rd["productDescription"].ToString();
            et.Thumb = rd["thumbName"].ToString();
            et.ClientID = Int32.Parse(rd["ClientID"].ToString());
            et.SortOrder = Int32.Parse(rd["orderedBy"].ToString());
            et.Extension = rd["FileExtension"].ToString();
            et.FileLenght = Int64.Parse(rd["FileLenght"].ToString());
            et.RelativePath = rd["RelativePath"].ToString();

            return et;
        }

    }

    
}
