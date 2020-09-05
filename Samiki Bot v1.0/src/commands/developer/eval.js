const { Client, Message } = require("discord.js")
const { success, testReaction, successWithInput, unsuccess } = require('../../Utils/embeds')
const { inspect } = require('util')

/**
 * The scope of command execution
 * @param {Client} client 
 * @param {Message} message 
 * @param {String} args 
 */
const run = async (client, message, args) => {
    if (message.author.id !== "367425061122211843") return

    const input = args.join(" ")

    try {

        let output = await eval(input)

        if (typeof output !== "string") output = inspect(output)

        if (output.length > 1900) output = output.substr(0, 1900)

        const emojis = {
            '🌈': "🌈 Para visualizar o input!",
            '💥': "💥 Para remover este eval!"
        }

        const emojisKey = Object.keys(emojis)

        const msg = await message.channel.send(
            success(output, emojisKey.reduce((acc, cur) => acc + emojis[cur], '')
            ))

        for (const emoji of emojisKey) await msg.react(emoji)

        const filter = (reaction, user) => reaction.me && user.id === message.author.id

        const options = { time: 60000, max: 2 }

        msg.createReactionCollector(filter, options)
            .on("collect", async reaction => {
                await reaction.remove()
                reaction.emoji.name == emojisKey[0] ? msg.edit(successWithInput(input, output)) : msg.delete()
            })

    } catch (error) {
        message.channel.send(unsuccess(error.message))
    }

}

module.exports = {
    help: {
        name: "Eval",
        description: "Command to test things",
        module: "Developer Only"
    },
    run: run,
    aliases: []
}