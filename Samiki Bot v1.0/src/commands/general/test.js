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
    name: "Test",
    description: "Just a Test",
    run: run,
    aliases: []
}