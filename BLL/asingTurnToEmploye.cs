using DAL;
using Entities;
using System;

namespace BLL
{
    public class asingTurnToEmploye
    {
        public bool createRequesClient()
        {
            using (var repository = RepositoryFactory.CreateRepository())
            {
                var lastTurn = getLastTurn();

                DateTime toDay = DateTime.Today.Date;
                if (this.turnOpen() != null)
                {
                    var result = repository.create<tbl_turn_position>(new tbl_turn_position
                    {
                        positionID = 1,
                        turnID = this.turnOpen().turnID,
                    });
                    if (result)
                    {
                        talk.talkin(lastTurn.description_Turn);
                        return true;
                    }
                }
                return false;
            }
        }

        public Tbl_Turns turnOpen()
        {
            using (var repository = RepositoryFactory.CreateRepository())
            {
                var estado = true;
                return repository.retrieve<Tbl_Turns>(x => x.status == estado);
            }
        }

        public Tbl_Turns getLastTurn()
        {
            using (var repository = RepositoryFactory.CreateRepository())
            {
                DateTime toDay = DateTime.Now.Date;
                return repository.Last<Tbl_Turns>(x => x.createOn == toDay && x.status == true);
            }
        }

        public bool update(Tbl_Turns turn)
        {
            turn.status = false;
            using (var repository = RepositoryFactory.CreateRepository())
            {
                return repository.update<Tbl_Turns>(turn);
            }
        }

        private int GetTypeServices(string description)
        {
            using (var repository = RepositoryFactory.CreateRepository())
            {
                return repository.retrieve<Tbl_Services>(x => x.serviceDescriotion == description).serviceID;
            }
        }

        private string GetSigleOfServices(string description)
        {
            using (var repository = RepositoryFactory.CreateRepository())
            {
                return repository.retrieve<Tbl_Services>(x => x.serviceDescriotion == description).servicesSgila;
            }
        }
    }
}