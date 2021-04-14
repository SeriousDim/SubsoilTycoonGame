# Subsoil Tycoon

**Экономический симулятор горнодобывающей компании**

Действие происходит на далекой-далекой планете, где игроку дается возможность управления собственной горнодобывающей компанией.
Игроку нужно будет расширяться, торговать, производить и продавать. На планете есть конкуренты, с которыми нужно будет бороться (добросовестно или нет)
за ресурсы в недрах планеты. Также на планете есть разбойники и дикари, которые тоже хотят поживиться.

## Структура мира
- Уровень представляет собой двумерный массив, каждая ячейка которого может быть занята зданием

**Здания**
- Здание может занимать несколько ячеек
- Здания можно строить на земле и друг на друге
- Здания соеденены конвеерами для передачи ресурсов друг другу
- Здания перерабатывают материал в новый материал и отдают его выходящим конвеерам
- Здание может держать в себе материалы

**Материалы**
- Есть в виде минералов и жидкостей - добываются по разному

## Геймплей
- Нужно строить здания на земле и туннели (работает как конвеер) под землей
- Под землей можно встретиться с туннелем конкурента
- Когда туннель натыкается на материал, начинается его добыча
- Есть материал, который нельзя добыть - его можн только обойти

**Случайные события**
- Может случиться обвал в туннеле. Тогда надо будет принудительно делать новый туннель, чтобы достать шахтеров. Завал убрать нельзя.
- Нападение дикарей или разбойников

## Че щас есть
![](https://downloader.disk.yandex.ru/preview/ece8b339b89c3087b29fdeaab4fae05a0b75d1e2ad0c1d35acd6d136e07142d0/60771409/erFjtlUlrYlt9Yp90A6XLoyLdnKimm4_ca72YNY5UfilPIZmNjt7AP6Q8BSqgzAnbEW0SdpODZrlxAnIchaGHw%3D%3D?uid=0&filename=SubTyccon1.PNG&disposition=inline&hash=&limit=0&content_type=image%2Fpng&owner_uid=0&tknv=v2&size=2048x2048)
