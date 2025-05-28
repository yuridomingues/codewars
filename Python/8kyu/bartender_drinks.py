def get_drink_by_profession(param):
    drinks = {
        "Jabroni": "Patron Tequila",
        "School Counselor": "Anything with Alcohol",
        "Programmer": "Hipster Craft Beer",
        "Bike Gang Member": "Moonshine",
        "Politician": "Your tax dollars",
        "Rapper": "Cristal",
    }
    for i, j in drinks.items():
        if i.lower() == param.lower():
            return j
    return "Beer"
