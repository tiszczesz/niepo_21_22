from tkinter import *
import sqlite3

with sqlite3.connect("details.db") as db:
    cursor=db.cursor()
cursor.execute(""" CREATE TABLE IF NOT EXISTS users(id integer PRIMARY KEY
               AUTOINCREMENT, username text NOT NULL, passwors text NOT NULL);""")
window = Tk()
window.geometry("450x280")

label1 = Label(text="Wprowadź nazwę:")
label1.place(x = 30,y = 40)
label1.config(bg='lightgreen',padx=0)
username = Entry(text = "")
username.place(x=150, y=40,width=200,height=24)
window.mainloop()