const RPC = require('discord-rpc')
const config = require('./src/config.json')
const client = new RPC.Client({ transport: 'ipc' })
const SetActivity = require('./Util/setActivity')

client.on('ready', async () => {
  console.log('Logged in!')
  console.log('Authed for user', client.user.username)
  SetActivity(client)
})

client.login({
  clientId: config.Client_ID,
  clientSecret: config.Client_Secret
});