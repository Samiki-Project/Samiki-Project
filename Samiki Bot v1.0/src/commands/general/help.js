const { Client, Message, MessageEmbed } = require("discord.js");
const HelpsArray = []

/**
 * The scope of command execution
 * @param {Client} client 
 * @param {Message} message 
 * @param {String} args 
 */
const run = async (client, message, args) => {

    /**
     * Convert an object with Map Keys to an Array of Keys
     * @param {Object} ks 
     * @param {Array} res 
     */
    const keysToArray = (ks, res = []) => {
        for (const key of ks) res.push(key)
        return res
    }
    const keys = keysToArray(client.commands.keys())

    /**
     * Stores help information exported for each command in a Array
     * @type {Array}
     */
    const helps = keys
        .map(key => client.commands.get(key).help)

    helps.forEach(element => {
        let a = 0;
        let help = new MessageEmbed()
            .setDescription(`
                Command:\n
                Name: ${element.name}
                Module: ${element.module}
                Description: ${element.description}
            `)
        HelpsArray.push(help)
    });
    HelpsArray.forEach(embed => {
        message.channel.send(embed)
    })
}

module.exports = {
    help: {
        name: "help",
        description: "Show the help command, with all my commands",
        module: "General"
    },
    run: run,
    aliases: []
}