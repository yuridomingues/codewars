def calculate_age(year_of_birth, current_year):
    if year_of_birth < current_year:
        age = current_year - year_of_birth
        if age > 1:
            return f"You are {age} years old."
        else:
            return f"You are {age} year old."
    elif year_of_birth > current_year:
        born_years = year_of_birth - current_year
        if born_years > 1:
            return f"You will be born in {born_years} years."
        else:
            return f"You will be born in {born_years} year."
    else:
        return "You were born this very year!"
    