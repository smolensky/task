using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using OnlineGameStore.Models;
using OnlineGameStoreData.Entities;
using OnlineGameStoreData.EntityReaders;
using OnlineGameStoreData.EntityWriters;

namespace OnlineGameStore.Controllers
{
    public class OnlineGameStoreController : ApiController
    {
        private readonly IGameEntityReader _gameEntityReader;
        private readonly IGameEntityWriter _gameEntityWriter;

        public OnlineGameStoreController(IGameEntityReader gameEntityReader,
                                            IGameEntityWriter gameEntityWriter)
        {
            _gameEntityReader = gameEntityReader;
            _gameEntityWriter = gameEntityWriter;
        }
        
        public IQueryable<GameEntity> ReadAllGames()
        {
            var result = _gameEntityReader.ReadAll();

            return result;
        }

        public GameEntity ReadGameByKey(string key)
        {
            var result = _gameEntityReader.ReadByKey(key);

            return result;
        }

        public IQueryable<GameEntity> ReadGameByGenre(GenreEntity genre)
        {
            var result = _gameEntityReader.ReadByGenre(genre);

            return result;
        }

        public IQueryable<GameEntity> ReadGameByPlatformType(PlatformTypeEntity platformType)
        {
            var result = _gameEntityReader.ReadByPlatformType(platformType);

            return result;
        }
    }
}
