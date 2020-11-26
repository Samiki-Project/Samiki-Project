const { MessageEmbed } = require('discord.js')

const successOutput = (output, footer) =>
    new MessageEmbed()
        .setTitle(`☄️ Success Output`)
        .setColor('#33cc1f')
        .setDescription("```js\n" + output + "```")
        .setFooter(footer)

const successOutputWithInput = (input, output) =>
    new MessageEmbed()
        .setTitle(`☄️ Success Output`)
        .setColor('#33cc1f')
        .setDescription("\n\n\n**Input** ```js\n" + input + "```" +
            "\n\n**Output** ```js\n" + output + "```")


const unsuccessOutput = (output) =>
    new MessageEmbed()
        .setTitle(`🚨 Unsuccess Output`)
        .setColor('#e60000')
        .setDescription("```js\n" + output + "```")

const testReaction = () =>
    new MessageEmbed()
        .setDescription('👾 This is a fucking robot =D')
        .setColor('#f542f5')


module.exports = {
    success: successOutput,
    unsuccess: unsuccessOutput,
    successWithInput: successOutputWithInput,
    testReaction: testReaction
}