from flask import Flask, render_template
from LoginForm import Lf
#from random import randint as rd

app = Flask(__name__)

@app.route('/')
def main():
    return render_template('base.html')

@app.route('/register')
def reg():
    form = Lf()
    if form.validate_on_submit():
        pass

    return render_template('register.html', title='Регистрация', form=form)


if __name__ == '__main__':
    app.run()




















# file = open('file.txt', 'r', encoding='utf-8')


# list_1 = list()

# resultData = list()

# for line in file.readlines():
#     resultData.append(tuple(line.split('\n')[0].split(';')))
    

# file.close()

# print(resultData)

# '''
# a - режим добавления
# w - режим на запись(очищает файл)
# r - режим считывания

# '''


