/**
 * Function that checks the command modules
 * @param {String} cmdName The Command Name
 * @param {String} cmdModule The Command Module
 * @returns true if everything is right or an error if something is wrong
 */
module.exports.checkCommandModule = (cmdName, cmdModule) => {
    if (!cmdModule.hasOwnProperty('help'))
        throw new Error(`${cmdName} command module does not have property 'help'`);
    if (!cmdModule.hasOwnProperty('run'))
        throw new Error(`${cmdName} command module does not have property 'run'`);
    if (!cmdModule.hasOwnProperty('aliases'))
        throw new Error(`${cmdName} command module does not have property 'aliases'`);
    return true;
}

/**
 * Function that checks the command properties
 * @param {String} cmdName The Command Name
 * @param {String} cmdModule The Command Module
 * @returns true if everything is right or an error if something is wrong
 */
module.exports.checkProperties = (cmdName, cmdModule) => {
    if (typeof cmdModule.help !== 'object')
        throw new Error(`${cmdName} command: 'help' property must be a object`);
    if (typeof cmdModule.run !== 'function')
        throw new Error(`${cmdName} command: 'run' property must be a function`);
    if (!Array.isArray(cmdModule.aliases))
        throw new Error(`${cmdName} command: 'aliases' property must be a Array`);
    return true;
}
