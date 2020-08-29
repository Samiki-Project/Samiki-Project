const chalk = require('chalk')
const moment = require('moment')
moment.locale('pt-br')

const colors = {
    success: chalk.bold.greenBright,
    err: chalk.bold.red,
    warn: chalk.bold.yellowBright,
    normal: (str) => str
}

/**
 * 
 * @param {String} system The system's name
 * @returns { (value: any, result: ('success'|'error'|'warn'|'normal')) => void }
 */
module.exports = (system) => (value, result = "normal") => {
    console.log(`[${system.toUpperCase()} ${moment().format('HH:mm')}] => ${colors[result.toLowerCase()](JSON.stringify(value))}`)
}