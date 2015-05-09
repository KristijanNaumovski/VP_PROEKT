# VP_PROEKT
<h1>Don’t Tap The White Tiles<br/>Кристијан Наумовски</h1>
<h3>Опис на играта/што е и како се игра:</h3>
<p>Don’t Tap The White Tiles е игра за една индивидуа во која целта на играчот е да кликнува само на црните полиња кој се појавуваат на екранот притоа избегнувајќи ги белите полиња. Играчот има избор дали да има звук во играта. Ако звукот е вклучен со секое кликнување на црно поле се емитува пиано звук. Играта има повеќе модови и тоа:</p>
<h5>---> 100 Tiles Game</h5>
<p>Играчот мора да кликне на 100 црни полиња за да победи. Екранот притоа се движи мануелно т.е со секое кликнување на црно поле. Целта на играта е играчот да кликне на 100 црни полиња за најкратко можно време притоа избегнувајќи ги белите полиња. Кликнување на бело поле значи крај на играта.</p>
<h5>---> 300 Tiles Game</h5>
<p>Играчот мора да кликне на 300 црни полиња за да победи. Екранот притоа се движи мануелно т.е со секое кликнување на црно поле. Целта на играта е играчот да кликне на 300 црни полиња за најкратко можно време притоа избегнувајќи ги белите полиња. Кликнување на бело поле значи крај на играта.</p>    	 
<h5>---> 30 Seconds Game</h5>
<p>Играчот ја игра играта 30 секунди. Екранот притоа се движи мануелно т.е со секое кликнување на црно поле. Целта на играта е играчот да кликне на што е можно повеќе црни полиња за време од 30 секунди притоа избегнувајќи ги белите полиња. Кликнување на бело поле значи крај на играта.</p>   	  
<h5>---> 1 Minute Game</h5>
<p>Играчот ја игра играта 1 минута. Екранот притоа се движи мануелно т.е со секое кликнување на црно поле. Целта на играта е играчот да кликне на што е можно повеќе црни полиња за време од 1 минута притоа избегнувајќи ги белите полиња. Кликнување на бело поле значи крај на играта.</p>
<p>Играта нуди и можност за гледање на најдобри резултати кои се остварени.</p>
<h3>Опис на решението на проблемот:</h3>
<p>Почетна форма на апликацијата е FirstForm каде што се одбира дали да се започне нова игра (New Game), кои се најдобрите резултати (Highscores), нешто околу играта (About) и копче за крај (Exit). Во формата selectGame се одбира модот на играта. Во формата NewGame се наоѓаат копчињата т.е црните и белите полиња. Во оваја форма се наоѓаат настаните на секое од копчињата т.е што да се случи кога некое копче/поле е кликнато. Во класата Leaderboard ги чувам најдобрите резултати за секоја од 4-те можни модови на играта. Резултатите за секоја игра ги чувам во посебна листа од играчи (Player). Преку оваа класа се читаат резултатите од текстуален фајл и се запишуваат соодветно. Од класта Player наследуваат 2 класи Player_Time и Player_Tiles. Овие класи го прикажуваат играчот т.е неговото име, презиме и оствареното времето или кликнатите црни полиња соодветно. Формата EnterNameAndSurname се појавува само кога корисникот успешно ќе ја заврши играта(ќе победи) и тогаш го внесува своето име и презиме.</p>
<h3>Опис на функција:</h3>
<pre>private void gameOver()
        {
            EnterNameAndSurname form = new EnterNameAndSurname();

            if (gameType == GAME_TYPE.TIMER_GAME)
            {
                timer.Stop();
                
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (seconds == 60)
                    {
                        leaderBoard.checkScoreFor1MinGame(new Player_Time(form.Name, form.Surname, counter));
                    }
                    else if (seconds == 30)
                    {
                        leaderBoard.checkScoreFor30SecGame(new Player_Time(form.Name, form.Surname, counter));
                    }
                }
                
            }
            else if (gameType == GAME_TYPE.TILES_GAME)
            {
                stopwatch.Stop();
                seconds = Convert.ToInt32(stopwatch.ElapsedMilliseconds) / 1000;

                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (tiles == 100)
                    {
                        leaderBoard.checkScoreFor100TilesGame(new Player_Tiles(form.Name, form.Surname, seconds));
                    }
                    else if (tiles == 300)
                    {
                        leaderBoard.checkScoreFor300TilesGame(new Player_Tiles(form.Name, form.Surname, seconds));
                    }
                }
            }

            String str = "Congratulations "+ form.Name + " " + form.Surname + " you have completed the game.\nYou hit " + counter + " black tiles for " + seconds + " sec.";
            DialogResult result = MessageBox.Show(str, "GAME OVER", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                firstForm.Show();
            }
        }
</pre>
<p>Оваа функција се повикува ако корисникот успешно ја заврши играта. Ако се работи за мод на временска игра најпрво го стоприрам тајмерот и се појавува форма за внес на име и презиме на корисникот а потоа во зависност дали се работи за 30secGame (seconds==30) или 1MinGame (seconds==60) ја повикувам функцијата checkScoreFor30SecGame(new Player_Time(form.Name, form.Surname, counter)) или
checkScoreFor1MinGame(new Player_Time(form.Name, form.Surname, counter)) од класата Leaderboard во кои проверувам дали остварениот резултат ќе влезе во 10те најдобри.
Ако се работи за мод на игра во која корисникот треба да кликне 100 или 300 полиња за одредено време ја спотирам стоперицата stopwatch.Stop(); со која го мерам времето. Потоа се појавува форма за внес на име и презиме на корисникот а потоа во зависност дали се работи за 100TileGame (tiles==100) или 300TilesGame (tiles==300) ја повикувам функцијата checkScoreFor100TilesGame(new Player_Tiles(form.Name, form.Surname, seconds)) или 
checkScoreFor300TilesGame(new Player_Tiles(form.Name, form.Surname, seconds)) од класата Leaderboard во кои проверувам дали остварениот резултат ќе влезе во 10те најдобри.
На крај се екран се појавува порака дека корисникот успешно ја завршил играта со соодветниот резултат, по што оваа форма се затвора и се прикажива почетната форма.
</p>
<h3>Screenshots:</h3>
<div><h3>Почетна форма:</h3><img src="http://s9.postimg.org/tu7x8vdjz/Dont_Tap_The_White_Tiles1.png"></div>
<div><h3>Најдобри резултати:</h3><img src="http://s17.postimg.org/6o63bm1u7/Dont_Tap_The_White_Tiles2.png"></div>
<div><h3>Околу играта:</h3><img src="http://s7.postimg.org/vjpp7r8pn/Dont_Tap_The_White_Tiles3.png"></div>
<div><h3>Избор на игра:</h3><img src="http://s21.postimg.org/d4r1itgmf/Dont_Tap_The_White_Tiles4.png"></div>
<div><h3>Играта:</h3><img src="http://s29.postimg.org/4x4yo4m1j/Dont_Tap_The_White_Tiles5.png"></div>
<div><h3>Форма за име и презиме по успешен крај на играта:</h3><img src="http://s29.postimg.org/i58xut8yf/Dont_Tap_The_White_Tiles6.png"></div>
<div><h3>Потврдна порака:</h3><img src="http://s30.postimg.org/k9z1g5eup/Dont_Tap_The_White_Tiles7.png"></div>
