
# Тестовое задание про расписание автобусов
Есть N автобусов, каждый автобус ездит по заранее известному циклическому маршруту. Известна стоимость проезда (оплачивается при входе в автобус) и время движения между остановками. Автобусы выходят на маршрут (появляются на первой остановке) в определенное время.
Необходимо написать программу, которая будет находить два пути: самый дешевый путь и самый быстрый путь. Интерфейс программы должен позволять загружать файл с маршрутами автобусов, выбирать начальную и конечную точки и время отправления из начальной точки.
>Формат входного файла:
>{N число автобусов}  
>{K число остановок}  
>{время отправления 1 автобуса} {время отправления 2 автобуса} ... {время отправления N автобуса}  
>{стоимость проезда на 1 автобусе} {стоимость проезда на 2 автобусе} ... {стоимость проезда на N автобусе}  
>{число остановок на маршруте 1 автобуса} {номер 1 остановки} {номер 2 остановки} ... {номер последней остановки} {время в пути между 1 и 2 остановкой} {время в пути между 2 и 3 остановкой} ... {время в пути между X и 1 остановкой}  
>...маршруты остальных автобусов ...  
>
>Пример:
>2  
>4  
>10:00 12:00  
>10 20  
>2 1 3 5 7  
>3 1 2 4 10 5 20  

Использованные алгоритмы:
* Алгоритм Дейкстра 
## Скриншот
<img src="https://sun9-62.userapi.com/impg/dPvuGZguaALeZShze95hq37TL44Ux0ZdkUZswQ/2P_TOu5-GvI.jpg?size=312x350&quality=96&sign=4d4cc2eb401903124fd44926cf69339e&type=album" width="50%" />
