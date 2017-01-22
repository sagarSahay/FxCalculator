let person = ("Mark", "Gray", "Man Utd", 22)

type Date = {
        day: int
        month: int
        year: int }

type Person = {
    firstName: string
    lastName: string
    favClub: string
    myAge: int
    dateOfBirth: Date }

let me = { firstName="Mark"; lastName="Gray"; favClub="ManU";myAge=22;dateOfBirth={day=9;month=8;year=86}}

let {firstName=myFirstName} = me
let {lastName=myLastName} = me
let {favClub=favClub} = me
let {myAge=myAge} = me

let myFullName= me.firstName + me.lastName

let temp = {me with myAge=30}

let updateDOB person birthDay =
    let updated = {person with dateOfBirth=birthDay}
    updated

updateDOB me {day=10;month=10;year=87}




    
    


