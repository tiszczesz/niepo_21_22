'use strict'

import readline from 'readline'

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
})

const question1 = () => {
  return new Promise<void>((resolve, reject) => {
    rl.question('q1 What do you think of Node.js? ', (answer:string) => {
      console.log(`Thank you for your valuable feedback: ${answer}`)
      resolve()
    })
  })
}

const question2 = () => {
  return new Promise<void>((resolve, reject) => {
    rl.question('q2 What do you think of Node.js? ', (answer:string) => {
      console.log(`Thank you for your valuable feedback: ${answer}`)
      resolve()
    })
  })
}

const main = async () => {
  await question1()
  await question2()
  rl.close()
}

main()