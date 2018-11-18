using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Threading;

namespace BLL
{
    //generate New Turns Logic
    public class Turns
    {
        public bool createNewTurns(int Type)
        {
            using (var repository = RepositoryFactory.CreateRepository())
            {
                var objServices = repository.retrieve<Tbl_Services>(x => x.serviceID == Type);
                int lastTurn = retrieveLastNumberOfTurn();
                string turnPlusSigle = objServices.servicesSgila + lastTurn.ToString();
                var result = repository.create<Tbl_Turns>(new Tbl_Turns
                {
                    description_Turn = objServices.serviceDescriotion,
                    turnID = lastTurn + 1
                });
                if (result)
                {
                    Thread task = new Thread(new ParameterizedThreadStart(talk.talkin));
                    task.Start(turnPlusSigle);
                }

                return result;
            }
        }

        public IEnumerable<Tbl_Turns> GetAllTurns()
        {
            using (var repository = RepositoryFactory.CreateRepository())
            {
                DateTime toDay = DateTime.Today.Date;
                return repository.GetAll<Tbl_Turns>(x => x.createOn == toDay);
            }
        }

        public int retrieveLastNumberOfTurn()
        {
            using (var repository = RepositoryFactory.CreateRepository())
            {
                return repository.Count<Tbl_Turns>(x => x.turnID);
            }
        }
    }
}