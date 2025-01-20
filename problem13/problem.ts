function romanToInt(s: string): number {
    const inputArr = Array.from(s);
    let sum = 0;
    let variable = '';

    inputArr.forEach((char,index) => {
        if (char === "I"){
            if(variable === ''){
                variable = char;
            } else if (variable === "X" || variable === "V"){
                sum += mapper[char] - mapper[variable];
                variable = ""
            }else{
                sum += mapper[variable];
                sum += mapper[char];
                variable = '';
            }
        } else if (char === "X"){
            if (variable === '') {
                variable = char;
            } else if (variable === "L" || variable === "C") {
                sum += mapper[char] - mapper[variable];
                variable = ""
            } else {
                sum += mapper[variable];
                sum += mapper[char];
                variable = '';
            }
        } else if (char === "C"){
            if (variable === '') {
                variable = char;
            } else if (variable === "D" || variable === "M") {
                sum += mapper[char] - mapper[variable];
                variable = ""
            } else {
                sum += mapper[variable];
                sum += mapper[char];
                variable = '';
            }
        }else{
            if(variable !== ''){
                sum -= mapper[variable];
                variable = '';
            }

            sum+= mapper[char];
        }
    });
    if (variable !== '') {
        sum += mapper[variable];
        variable = '';
    }

    return sum;
};

const mapper = {
    "I": 1,
    "V": 5,
    "X": 10,
    "L": 50,
    "C": 100,
    "D": 500,
    "M": 1000
}

console.log(romanToInt("III"));
console.log(romanToInt("LVIII"));
console.log(romanToInt("MCMXCIV"));
console.log(romanToInt("DCXXI"));