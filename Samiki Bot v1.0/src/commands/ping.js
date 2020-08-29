const { Client, Message } = require("discord.js");
const log = require('sk-log')("PING")
const {
    methods: { incrementDataValue }
} = require("sk-manager");

/**
 * Command that returns the current system and API latency
 * @param {Client} client 
 * @param {Message} message 
 * @param {String} args 
 */
exports.run = async (client, message, args) => {
    const m = await message.channel.send("Ping?")
    await m.edit(`:ping_pong: Pong!\nMy Latency: ${m.createdTimestamp - message.createdTimestamp}ms \nAPI Latency: ${Math.round(client.ws.ping)}ms`)
    await incrementDataValue("bot/latencies", 1)
    .then(() => log("O comando foi executado com sucesso!", "success"))
    .catch(err => log(`Houve um erro...\n\n\n${err}`, "Error"))
}