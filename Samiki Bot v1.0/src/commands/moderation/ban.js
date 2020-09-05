const { Client, Message } = require("discord.js")

/**
 * The scope of command execution
 * @param {Client} client 
 * @param {Message} message 
 * @param {String} args 
 */
const run = async (client, message, args) => {
    if (!message.member.hasPermission('BAN_MEMBERS') || !message.member.hasPermission('ADMINISTRATOR')) {
        message.reply("Você não tem permissão para fazer isso!");
        return message.react(':X:');
    }
    message.channel.send('Under Construction')
}

module.exports = {
    help: {
        name: "Ban",
        description: "Ban Some Member",
        module: "Moderation"
    },
    run: run,
    aliases: []
}