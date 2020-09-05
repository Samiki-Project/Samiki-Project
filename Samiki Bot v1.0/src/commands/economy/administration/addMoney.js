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
        name: "addMoney",
        description: "Command to Administration give money to a member",
        module: "Economy"
    },
    run: run,
    aliases: []
}