from turtle import *
from random import randint, choice
from time import sleep


FINISH = 200  # дистанция гонки


def new_turtle(coord, color):  # Функция для создания черепахи
    t = Turtle()  # создали объект класса черепахи
    t.shape("turtle")  # черепаха в форме черепахи
    t.color(color)  # цвет черепахи
    t.penup()  # поднимаем черепашку чтоб не рисовала
    t.goto(-FINISH, coord)  # и перемещаем черепашку на старт
    t.pendown()  # опускаем черепашку чтоб потом рисовала
    t.speed(1)  # Скорость черепахи увеличивается от 1-медленно до 9-быстро, но 0 самая быстрая

    def catch(x, y):  # это обработчик события нажатия
        scream = choice(('Ouch!', 'Piss OFF!', 'Get OUT!', 'SUKA!', "D'oh!"))  # Вопль черепахи
        rand_move = randint(10, 16)  # Размер шрифта вопля и случайного шага
        t.write(scream, font=('Arial', rand_move, 'bold'))  # пишем на экране вопль
        t.fd(rand_move)  # черепашка делаем случайный шаг от 10 до 15
    t.onclick(catch)  # здесь я прикрепляю обработчик к событию нажатия на черепашку
    return t


def field_layout():  # функция рисует разметку полня
    field_line = Turtle()
    field_line.color('gray')
    field_line.speed(0)
    for i in range(1, FINISH // 10 + 1):
        field_line.penup()
        field_line.goto(-FINISH + i * 20, 50)
        field_line.pendown()
        field_line.goto(-FINISH + i * 20, -100)
    field_line.hideturtle()


# Создаем трех черепах и рисуем поле
t1 = new_turtle(20, "red")
t2 = new_turtle(-20, "blue")
t3 = new_turtle(-60, "green")
field_layout()

# Движения черепах к финишу
while t1.xcor() < FINISH and t2.xcor() < FINISH and t3.xcor() < FINISH:
    # здесь черепаха двигается вперед и рисует в диапазоне от 2 о 7
    t1.forward(randint(2, 7))
    t2.forward(randint(2, 7))
    t3.forward(randint(2, 7))
    sleep(0.05)