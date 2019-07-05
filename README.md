# Игра за деца со посебни потреби

### 1. Вовед 

Играта е поделена на три категории [Премини улица](https://github.com/DimoskiBojan/VP_Proekt/blob/master/VP_Proekt/VP_Proekt/Ulica.cs) , [Временска ориентација](https://github.com/DimoskiBojan/VP_Proekt/blob/master/VP_Proekt/VP_Proekt/Vremenska.cs) и [Просторна ориентација](https://github.com/DimoskiBojan/VP_Proekt/blob/master/VP_Proekt/VP_Proekt/Prostorna.cs). Сите три категории се визуелизирани со слики и видливи награди(поени, progress bar, smiley emoji's). Визуелизацијата им помога на децата со посебни потреби да научат која е правилната одлука што треба да ја донесат, која што претставува целта на оваа игра. Целта е да научат правилно да преминат улица, да имаат ориентација за лево и десно, а воедно да ги научат овошјата и зеленчуците и да научат која облека се носи во временските сезони Зима и Лето. 

  
  ---

### 2. Упатсво за играње

#### 2.1 Премини улица

![picture alt](https://github.com/DimoskiBojan/VP_Proekt/blob/master/Sliki/ulica.PNG) 

Карактерот кој се наоѓа на тротоарот треба правилно да премине преку улицата преку притискање на копчињата Up, Down, Right и Left од тастатурата. Карактерот е ограничен во неговото движење, тоа значи дека кога ќе направи грешка го известуваме дека направил грешка со помош на формата [Pomoshna](https://github.com/DimoskiBojan/VP_Proekt/blob/master/VP_Proekt/VP_Proekt/Pomoshna.cs) и го враќаме на последната валидна состојба. <br />

##### Ова се некои од ограничувањата кои што ние ги имаме имплементирано во нашиот код во класата [Covece](https://github.com/DimoskiBojan/VP_Proekt/blob/master/VP_Proekt/VP_Proekt/Covece.cs):
- Карактерот не може да се движи по улицата доколку не е во опсегот на пешачкиот премин
```csharp
    public bool CheckLocation()
        {
            //Zebra Width=2 * person.Width
            //semaphore Width=90
            int startOfZebra = formWidth - 90 - 2 * person.Width - 20;
            int endOfZebra = startOfZebra + 2 * person.Width;
            if(X>=startOfZebra-10 && X+person.Width<=endOfZebra+10)
            {
                return true;
            }
            return false;
        }
```
- Карактерот стои на пешачкиот премин додека е црвено или немал доволно време да го помине пешачкиот премин па затоа го враќаме на последната валидна состојба 
```csharp
public void NaZebraICrvenoSvetlo()
        {
            //the end point
            int pocetokulica = Resources.sidewalk_Up.Height-20;
            int krajulica = pocetokulica + Resources.street.Height;
            if (!lightColor && Y>pocetokulica && Y<krajulica)
            {
                Y = 300;
            }
        }
```
- Карактерот е на пешачки и сака да се движи лево и десно од пешачкиот
```csharp
if (direction == DIRECTION.LEFT)
            {
                person = Resources.Person1_Left;
                if ((X - 10) > 0)
                {
                    X-= 10;
                }
                if(Y<300)
                {
                    //the person is on the Zebra and wants to go  Left
                    if (!CheckLocation())
                    {
                        X += 10;
                    }
                }
            }
            if (direction == DIRECTION.RIGHT)
            {
                person = Resources.Person1_Right;
                if ((X + 10) < formWidth-person.Width)
                {
                    X += 10;
                }
                if (Y < 300)
                {
                    //the person is on the Zebra and wants to go Right 
                    if (!CheckLocation())
                    {
                        X -= 10;
                    }
                }
            }
```


#### 2.2 Временска ориентација
Во овој дел од играта првично треба да се избере сликичка за со кој карактер би сакале да играат и во која временска сезона.

![picture alt](https://github.com/DimoskiBojan/VP_Proekt/blob/master/Sliki/VremenskaIzbor.PNG)

Откако се избрани карактерот и временската сезона треба да се изберат соодветните алишта за избраната сезона.

![picture alt](https://github.com/DimoskiBojan/VP_Proekt/blob/master/Sliki/VremeskaZimaDevojce.PNG)![picture alt](https://github.com/DimoskiBojan/VP_Proekt/blob/master/Sliki/goalVremenskaDevojce.PNG)

Во овој дел се користат следниве форми и класи:
 1. Форми:
  * [VremenskaIzbor](https://github.com/DimoskiBojan/VP_Proekt/blob/master/VP_Proekt/VP_Proekt/VremenskaIzbor.cs)
  * [Vremenska](https://github.com/DimoskiBojan/VP_Proekt/blob/master/VP_Proekt/VP_Proekt/Vremenska.cs)
  * [Pomoshna](https://github.com/DimoskiBojan/VP_Proekt/blob/master/VP_Proekt/VP_Proekt/Pomoshna.cs)
2. Класи:
  * [Obleka](https://github.com/DimoskiBojan/VP_Proekt/blob/master/VP_Proekt/VP_Proekt/Obleka.cs)
  * [KlasaZaObleki](https://github.com/DimoskiBojan/VP_Proekt/blob/master/VP_Proekt/VP_Proekt/KlasaZaObleki.cs)

#### 2.3 Просторна ориентација

Тука е потребно да се стават Овошјата и Зеленчуците во соодветниот listBox. Наградата има за секој погодок и тоа се: поен плус во делот за Погодени, Исполнување на ProgressBar и Smily Emoji ,претставено со помош на [Pomoshna](https://github.com/DimoskiBojan/VP_Proekt/blob/master/VP_Proekt/VP_Proekt/Pomoshna.cs), доколку победи.

![picture alt](https://github.com/DimoskiBojan/VP_Proekt/blob/master/Sliki/Prostorna.PNG)

Во овој дел има опции за додавање и бришење на ставки. Опцијата за додавање ни отвара нова форма во која што имаме имплементирано валидација на Името, валидација на Описот и воедно внес на слика. 

![picture alt](https://github.com/DimoskiBojan/VP_Proekt/blob/master/Sliki/DodadiStavka.PNG)
