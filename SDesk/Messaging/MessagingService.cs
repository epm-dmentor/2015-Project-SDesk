using System;
using System.Collections.Specialized;
using System.Configuration;
using RabbitMQ.Client;

namespace Epam.Sdesk.Messaging
{
    public class MessagingService:IMessagingService
    {
        #region Fields
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger
        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private NameValueCollection _messagingConfig;
        private readonly string _exchangeName;
        private readonly string _hostname;
        private readonly string _queueOne;
        private readonly string _queueTwo;
        private readonly string _routingKey;
        #endregion

        #region Constructor
        public MessagingService () 
        {
            try
            {
                _messagingConfig = ConfigurationManager.GetSection("Messaging") as NameValueCollection;
                _hostname = _messagingConfig["hostname"];
                _exchangeName = _messagingConfig["exchangeName"];
                _queueOne = _messagingConfig["queueOne"];
                _queueTwo = _messagingConfig["queueTwo"];
       
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns connection to RabbitMQ Messaging
        /// </summary>
        /// <returns></returns>
        public IConnection GetRabbitMqConnection()
        {
            try
            {
                var connectionFactory = new ConnectionFactory
                {
                    HostName = _hostname
                };

                _log.Info("Successfully connected to RabbitMQ at host ");
                
                return connectionFactory.CreateConnection();
            }
            
            catch (Exception ex)
            {
                _log.Error("Could not connect to RabbitMq. Exception is: " + ex.Message);
                
                return null;
            }

        }
        /// <summary>
        /// Sets up Exchange and Binds Queues
        /// </summary>
        /// <param name="model"></param>
        public void SetUpExchangeAndQueues(IModel model)
        {
            model.ExchangeDeclare(_exchangeName, ExchangeType.Topic, true);
            model.QueueDeclare(_queueOne, true, false, false, null);
            model.QueueDeclare(_queueTwo, true, false, false, null);
            model.QueueBind(_queueOne, _exchangeName, "");
            model.QueueBind(_queueTwo, _exchangeName, "");
        }
        #endregion
    }
}
