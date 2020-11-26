require('dotenv').config()
require("module-alias/register")
require('sk-database')
const log = require('sk-log')("MAIN-BRAIN")

const { Client } = require('discord.js')
const client = new Client();

client.commands = new Map()
const { registerCommands, commandStatus } = require('./handlers/Command/registry');

client.on('ready', () => log("I'm Ready! >.<", "success"))
client.on('error', (error) => log(`Something wrong: ${error}`, "error"))
client.on('warn', (warn) => log(`There's the warn: ${warn}`, "warn"))

client.on('message', async message => {
	const args = message.content.slice(process.env.PREFIX.length).trim().split(/ +/g);
	const command = args.shift().toLowerCase();

	if (message.author.bot) return;
	if (message.channel.type === "dm") return;
	if (!message.content.startsWith(process.env.PREFIX)) return;

	if (client.commands.get(command)) client.commands.get(command)['run'](client, message, args)
	else message.channel.send("That command does not exist!")
});

(async () => {
	client.login(process.env.TOKEN);
	await registerCommands(client, '../../commands')
	setTimeout(() => {
		for (command of commandStatus) {
			if (command[1] === "Success") log(`The command '${command[0]}' was successfully loaded`, "success")
			else if (command[1] === "Failed") log(`The command '${command[0]}' was NOT successfully loaded`, "error")
			else log("There's Something wrong...", "warn")
		}
	}, 5000);
})()