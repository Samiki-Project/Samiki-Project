const { Client, Message } = require("discord.js")

/**
 * The scope of command execution
 * @param {Client} client 
 * @param {Message} message 
 * @param {String} args 
 */
const run = async (client, message, args) => {

}

module.exports = {
    help: {
        name: "Daily",
        description: "Command to give you your daily reward",
        module: "Economy"
    },
    run: run,
    aliases: []
}