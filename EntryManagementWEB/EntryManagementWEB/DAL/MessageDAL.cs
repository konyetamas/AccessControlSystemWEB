using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntryManagementWEB.DB;
using EntryManagementWEB.Model;

namespace EntryManagementWEB.DAL
{
    public class MessageDAL
    {
        public static void AddNewMessage(MessageFromCompanyModel messageModel)
        {
            AccessControlSystemEntities context = new AccessControlSystemEntities();
            try
            {
                MessageFromCompany messageDB = MaptoMessageFromCompanyDBModel(messageModel, context);
                context.MessageFromCompanies.Add(messageDB); 
            }
            catch(Exception e )
            {

            }
        }




        public static List<MessageToCompanyModel> GetMessagesFromBuildingToCompany(int CompanyId)
        {

            AccessControlSystemEntities context = new AccessControlSystemEntities();
            try
            {
                List<MessageFromBuilding> messagesDB = (from x in context.MessagesOfCompanies
                                                      from y in context.MessageFromBuildings
                                                      where x.CompanyId == CompanyId
                                                      where x.MessageFromBuildingId == y.Id
                                                      select y).ToList();
                                                                     
                List<MessageToCompanyModel> messagesModel = new List<MessageToCompanyModel>();
                foreach (MessageFromBuilding item in messagesDB)
                {
                    messagesModel.Add(MapToMessageToCompanyModel(item, context));
                }
                return messagesModel;
            }
            catch (Exception e)
            {

            }
            return null;
        }

        private static MessageFromCompanyModel MapToMemberMessageFromCompanyModel(MessageFromCompany messageFromCompanyDB, AccessControlSystemEntities context)
        {
            MessageFromCompanyModel messageFormCompany = new MessageFromCompanyModel();
            messageFormCompany.Id = messageFromCompanyDB.Id;
            messageFormCompany.Text = messageFromCompanyDB.Value;
            messageFormCompany.CompanyName = (from x in context.MessageFromCompanies
                                       where x.Id == messageFormCompany.Id
                                       from y in context.Companies
                                       where y.Id == x.CompanyId
                                       select y.Name
                                      ).FirstOrDefault();

            return messageFormCompany;
        }


        private static MessageToCompanyModel MapToMessageToCompanyModel(MessageFromBuilding messageFromBulidingDB, AccessControlSystemEntities context)
        {
            MessageToCompanyModel messageToCompany = new MessageToCompanyModel();
            messageToCompany.Id = messageFromBulidingDB.Id;
            messageToCompany.Text = messageFromBulidingDB.Value;
            messageToCompany.Date = messageFromBulidingDB.Date;
            messageToCompany.Subject = messageFromBulidingDB.Subject;
            return messageToCompany;
        }


        private static MessageFromCompany MaptoMessageFromCompanyDBModel(MessageFromCompanyModel messageFromCompanyModel, AccessControlSystemEntities context)
        {
            MessageFromCompany messageFromCompanyDB = new MessageFromCompany();
            messageFromCompanyDB.Value = messageFromCompanyModel.Text;
            messageFromCompanyDB.Date = messageFromCompanyModel.Date;
            messageFromCompanyDB.Subject = messageFromCompanyModel.Subject;
            return messageFromCompanyDB;
        }


    }
}
