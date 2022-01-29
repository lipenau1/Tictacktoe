using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TestArquive.Game;

namespace TestArquive.Controllers
{
    [Route("api/tictactoe")]
    [ApiController]
    public class GameController : ControllerBase
    {
        [HttpPost("player")]
        public ActionResult Player(int pos1, int pos2)
        {
            if (PlayerPlay.Player(pos1, pos2))
            {
                if (Logic.winner == 0)
                {
                    Logic.CheckBoard();
                    if (Logic.winner != 0)
                    {
                        return Ok();
                    }
                }
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost("bot")]
        public ActionResult Bot()
        {
            BotPlay.BotTurn();
            if (Logic.winner == 0)
            {
                Logic.CheckBoard();
            }
            return Ok();
        }

        [HttpDelete("reset")]
        public void ResArray()
        {
            Reset.ResetArray();
        }

        [HttpGet("winner")]
        public int Winner()
        {
            int win = CheckWinner.CheckWinners(Logic.winner);
            if (win != 0)
            {
                Logic.winner = 0;
                return win;
            }
            return win;
        }

        [HttpGet]
        public List<int> Get()
        {
            List<int> num = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num.Add(Logic.arrGame[i, j]);
                }
            }
            return num;
        }

    }
}
