using DAL;
using Entities;
using System;
using System.Collections.Generic;

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
                var lastTurns = LastTurnOfDay(objServices.servicesSgila.Substring(0, 1));
                DateTime? dayRegisterLastTurn = lastTurns.createOn;
                string turnPlusSigle = objServices.servicesSgila + (dayRegisterLastTurn == null ? 1 : lastTurns.turnID + 1);

                var result = repository.create<Tbl_Turns>(new Tbl_Turns
                {
                    description_Turn = turnPlusSigle,

                    createOn = DateTime.Today.Date,
                    status = true
                });
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

        public Tbl_Turns LastTurnOfDay(string initials)
        {
            using (var repository = RepositoryFactory.CreateRepository())
            {
                DateTime toDay = DateTime.Today.Date;

                var result = repository.retrieve<Tbl_Turns>(x => x.createOn == toDay && x.description_Turn.StartsWith(initials));
                return result == null ? new Tbl_Turns() : result;
            }
        }
    }
}