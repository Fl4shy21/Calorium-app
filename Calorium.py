from tkinter import *
from tkinter import ttk

def calculate_calories():
    try:
        weight = float(weight_entry.get())
        height = float(height_entry.get())
        age = int(age_entry.get())

        bmr = 88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age)

        activity_factor = activity_factors[activity_var.get()]

        maintenance_calories = bmr * activity_factor

        result_label_tab2.config(text=f"Your maintenance calories: {maintenance_calories:.2f} kcal")
    except ValueError:
        result_label_tab2.config(text="Please enter valid numerical values!")

root = Tk()
root.title("Calorium")

frame = Frame(root)
frame.pack(fill=BOTH, expand=True)

notebook = ttk.Notebook(frame)

tab1 = Frame(notebook)
tab2 = Frame(notebook)
tab3 = Frame(notebook)
tab4 = Frame(notebook)

notebook.add(tab1, text="Introduction")
notebook.add(tab2, text="Caloric Calculator")
notebook.add(tab3, text="Get to understand")
notebook.add(tab4, text="Choose your schedule")
notebook.pack(fill=BOTH, expand=True)

canvas_tab1 = Canvas(tab1)
canvas_tab1.pack(fill=BOTH, expand=True)

canvas_tab2 = Canvas(tab2)
canvas_tab2.pack(fill=BOTH, expand=True)

canvas_tab3 = Canvas(tab3)
canvas_tab3.pack(fill=BOTH, expand=True)

canvas_tab4 = Canvas(tab4)
canvas_tab4.pack(fill=BOTH, expand=True)

Label(canvas_tab1, text="Hello, welcome to Calorium! This app will help you stay on track with your diet, in order to maintain your aesthetic physique.", font=('Verdana', 9, 'bold')).pack()
Label(canvas_tab1, text="Here on Calorium, you can also choose from multiple recipes of both healthy and delicious meals.", font=('Verdana', 9, 'bold')).pack()
Label(canvas_tab1, text="As expected, these meals are high protein and low to 0 sugar.", font=('Verdana', 9, 'bold')).pack()

scrollbar_tab1 = Scrollbar(canvas_tab1, orient=VERTICAL, command=canvas_tab1.yview)
scrollbar_tab1.pack(side=RIGHT, fill=Y)

Label(canvas_tab2, text="This is going to be your caloric calculator. Here you can calculate your maintenance calories.", font=('Verdana', 9, 'bold')).pack()
Label(canvas_tab2, text="If you didn't know: ", font=('Verdana', 9, 'bold')).pack()
Label(canvas_tab2, text="Maintenance calories = The number of calories to consume in order to maintain the same bodyweight", font=('Verdana', 9, 'bold')).pack()
Label(canvas_tab2, text="Down below, there is a calculator meant to calculate your maintenance calories.",font=('Verdana', 9, 'bold')).pack()
Label(canvas_tab2, text="Please introduce your weight, height, age, gender and levels of daily activity in order to allow us to calculate your maintenance calories.",font=('Verdana', 9, 'bold')).pack()

scrollbar_tab2 = Scrollbar(canvas_tab2, orient=VERTICAL, command=canvas_tab2.yview)
scrollbar_tab2.pack(side=RIGHT, fill=Y)

weight_label = Label(canvas_tab2, text="Weight (kg):")
weight_label.pack()

weight_entry = Entry(canvas_tab2)
weight_entry.pack()

height_label = Label(canvas_tab2, text="Height (cm):")
height_label.pack()

height_entry = Entry(canvas_tab2)
height_entry.pack()

age_label = Label(canvas_tab2, text="Age:")
age_label.pack()

age_entry = Entry(canvas_tab2)
age_entry.pack()

activity_factors = {
    "Sedentary": 1.2,
    "Lightly active": 1.375,
    "Moderately active": 1.55,
    "Very active": 1.725,
    "Extra active": 1.9,
}

activity_label = Label(canvas_tab2, text="Activity Level:")
activity_label.pack()

activity_var = StringVar()
activity_var.set("Sedentary")

activity_menu = OptionMenu(canvas_tab2, activity_var, *activity_factors.keys())
activity_menu.pack()

result_label_tab2 = Label(canvas_tab2, text="", font=('Verdana', 12))
result_label_tab2.pack(pady=10)

calculate_button = Button(canvas_tab2, text="Calculate", command=calculate_calories)
calculate_button.pack()

result_label = Label(canvas_tab2, text="", font=('Verdana', 12))
result_label.pack(pady=10)

Label(canvas_tab3, text="Before you begin your journey, we advise you to read what you can see below.", font=('Verdana', 9, 'bold')).pack()
Label(canvas_tab3, text="Basically, it can help you understand better the difference between a ", font=('Verdana', 9, 'bold')).pack()
Button(canvas_tab3, text="CUT", font=('Rubik', 10, 'bold'), command=lambda:update_label_text("A cut (a.k.a caloric deficit) means that you consume less calories than you burn, in order to lose weight.")).pack()
Button(canvas_tab3, text="How many calories should I cut?", font=('Rubik', 10, 'bold'), command=lambda:update_label_text("A cut is best done when you are reducing your daily calorie intake by 400-500 calories, while getting a healthy amount of protein too.\n In order to know your actual calorie intake while cutting, start off by calculating your maintenance calories.\n You can find a calculator which can help you on the second tab.")).pack()
Label(canvas_tab3, text="and", font=('Verdana', 9, 'bold')).pack()
Button(canvas_tab3, text="BULK", font=('Rubik', 10, 'bold'), command=lambda:update_label_text("A bulk (a.k.a caloric surplus) is the exact opposite of a cut. You eat more calories than you burn, in order to gain weight.")).pack()
Button(canvas_tab3, text="Types of bulking and the differences between them", font=('Rubik', 10, 'bold'), command=lambda:update_label_text("A clean bulk is, obviously the more healthier approach when it comes to gaining weight.\n It consists of a controlled and pretty restricted diet. Occassionally, cheat meals are allowed. \n While, a dirty bulk consists of any type of food, even fast and processed foods.\n This approach is considered too risky for your health, because it can cause high blood pressure, rapid weight and fat gain, and not too much amounts of muscle gain.\n")).pack()

Label(canvas_tab3, text="Now, you should know about the other things you need to consider when eating controlled and healthy, and that is: macronutrients.\n The macronutrients (a.k.a macros) are essential for a healthy diet.\n Macronutrients play an important role in the body's energy levels and overall structure. \n There are three types of macronutrients: fats, carbohydrates and proteins. \n By pressing on the buttons below, you will understand each of their roles much better.", font=('Rubik', 10, 'bold')).pack()
Button(canvas_tab3, text="Fats", font=('Rubik', 10, 'bold'), command=lambda:update_label_text("Fats for the human body are exactly the same as fuel for the car's engine.\n Fats are used to build hormones, cells and nerve tissues.\n")).pack()
Button(canvas_tab3, text="Carbohydrates", font=('Rubik', 10, 'bold'), command=lambda:update_label_text("Carbohydrates (fiber, starches and sugars) are used by the human body by transforming them into glucose, resulting energy.\n There are two types of carbohydrates: simple and complex.\n Simple carbs could be: sodas, sweets, cookies, fast food, white bread etc. While complex carbs are the: fruits, vegetables, whole grains, brown rice etc.\n Simple carbs are known to be more easily digestible for the body, the complex carbs are the exact opposite.\nThey take longer to digest because they aren't processed and they are higher in fiber, vitamins and minerals.\n")).pack()
Button(canvas_tab3, text="Proteins", font=('Rubik', 10, 'bold'), command=lambda:update_label_text("Proteins are the molecules that used to repair cells and of course, build muscle.\n The process to build muscle, is known as protein synthesis.\n")).pack()

scrollbar_tab3 = Scrollbar(canvas_tab3, orient=VERTICAL, command=canvas_tab3.yview)
scrollbar_tab3.pack(side=RIGHT, fill=Y)

result_label = Label(canvas_tab3, text="", font=('Verdana', 12))
result_label.pack(pady=10)

def update_label_text(text):
    result_label.config(text=text)

Label(canvas_tab4, text="After studying about the correct way of maintaining a diet, you should be aware of your training schedule as well.\n By pressing the buttons down below, you can notice both a 3 day and a 4 day workout plan.\n You can choose from these two the one which seems more suitable to your daily plans.\n", font=('Verdana', 9, 'bold')).pack()

scrollbar_tab4 = Scrollbar(canvas_tab4, orient=VERTICAL, command=canvas_tab4.yview)
scrollbar_tab4.pack(side=RIGHT, fill=Y)

def update_label_text_tab4(text):
    result_label_tab4.config(text=text)

Button(canvas_tab4, text="3 day plan (Push-Pull-Legs)", font=('Rubik', 10, 'bold'), command=lambda: update_label_text_tab4("Day 1 (Chest, triceps and shoulders) \n (Bench press, 2*failure),\n (Incline bench press, 2*failure),\n (Dumbbell chest flys, 1*failure),\n (Incline pushups, 1*failure),\n (Standard pushups, 1*failure).\n (Shoulder press, 2*failure),\n (Lateral raises, 2*failure),\n (Cable face pulls, 2*failure).\n (Pushdowns, 2*failure),\n (Overhead tricep extension, 1*failure on each tricep).\n Day 2: Pull (Back, biceps, traps):\n (Pull-ups, 2*failure),\n (T-bar Rows, 2*failure),\n (Barbell rows, 2* failure).\n Preacher curls (2*failure),\n Barbell curls (2*failure),\n Chin-ups (1*failure).\n Cable shrugs (2*failure),\n Dumbbell bent over raises (2*failure).\n Day 3: Legs:\n Squats (2*failure),\n Leg extensions (2*failure),\n Leg curls (2*failure),\n Calf raises (2*failure).")).pack()
Button(canvas_tab4, text="4 day plan (Chest-triceps, Back-biceps, Legs-Calves and Shoulders-Traps)", font=('Rubik', 10, 'bold'), command=lambda: update_label_text_tab4("Day 1 (Chest and triceps): (Bench press, 2*failure),\n (Incline bench press, 2*failure),\n (Dumbbell chest flys, 1*failure),\n (Incline pushups, 1*failure),\n (Standard pushups, 1*failure).\n (Pushdowns, 2*failure),\n (Overhead tricep extension, 2*failure).\n Day 2 (Back and biceps):\n (Pull-ups, 2*failure),\n (T-bar Rows, 2*failure),\n (Barbell rows, 2* failure).\n (Chin-ups, 2*failure);\n (Preacher curls, 2*failure);\n (Barbell curls, 2*failure).\n Day 3 (Legs):\n (Squats, 2*failure);\n (Leg extensions, 2*failure);\n (Leg curls, 2*failure);\n (Calf raises, 2*failure).\n Day 4: Shoulders and Traps:\n (Shoulder press, 2*failure);\n (Lateral raises, 2*failure);\n (Cable face pulls, 2*failure);\n (Cable shrugs, 2*failure);\n (Dumbbell bent over raises, 2*failure).\n")).pack()
Label(canvas_tab4, text="You may notice that each sets of each exercises on everyday are performed until failure.\n This method, named Heavy Duty Method, was initialized by famous bodybuilder Mike Mentzer in the 1970s.\n It is known to be the best method of working out for natural lifters.\n It consists of picking heavy weights, and doing 10 reps maximum.\n The 10+ rep range is considered to be hypertrophy by many people in the industry.\n ", font=('Verdana', 9, 'bold')).pack()

result_label_tab4 = Label(canvas_tab4, text="", font=('Verdana', 12))
result_label_tab4.pack(pady=10)

root.mainloop()