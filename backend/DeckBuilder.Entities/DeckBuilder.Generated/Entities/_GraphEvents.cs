#pragma warning disable S101 // Types should be named in PascalCase
#pragma warning disable CS8981 // Names should not be lower type only

using System;

using Blueprint41;
using Blueprint41.Core;
using Blueprint41.DatastoreTemplates;

namespace DeckBuilder.Generated.Manipulation
{
    public static class GraphEvents
    {
        public static class Nodes
        {
            public static class Action
            {
                public static readonly Entity Entity = DeckBuilder.Model.Datastore.Model.Entities["Action"];

                #region OnNodeLoading

                private static bool onNodeLoadingIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoading;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoading
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading += onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = true;
                            }
                            onNodeLoading += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoading -= value;
                            if (onNodeLoading is null && onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading -= onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadingProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoading;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeLoaded

                private static bool onNodeLoadedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoaded;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoaded
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded += onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = true;
                            }
                            onNodeLoaded += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoaded -= value;
                            if (onNodeLoaded is null && onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded -= onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoaded;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnBatchFinished

                private static bool onBatchFinishedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onBatchFinished;
                public static event EventHandler<Entity, NodeEventArgs> OnBatchFinished
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished += onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = true;
                            }
                            onBatchFinished += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onBatchFinished -= value;
                            if (onBatchFinished is null && onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished -= onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onBatchFinishedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onBatchFinished;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreate

                private static bool onNodeCreateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate += onNodeCreateProxy;
                                onNodeCreateIsRegistered = true;
                            }
                            onNodeCreate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreate -= value;
                            if (onNodeCreate is null && onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate -= onNodeCreateProxy;
                                onNodeCreateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreated

                private static bool onNodeCreatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated += onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = true;
                            }
                            onNodeCreated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreated -= value;
                            if (onNodeCreated is null && onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated -= onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdate

                private static bool onNodeUpdateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate += onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = true;
                            }
                            onNodeUpdate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdate -= value;
                            if (onNodeUpdate is null && onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate -= onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdated

                private static bool onNodeUpdatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated += onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = true;
                            }
                            onNodeUpdated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdated -= value;
                            if (onNodeUpdated is null && onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated -= onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDelete

                private static bool onNodeDeleteIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDelete;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDelete
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete += onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = true;
                            }
                            onNodeDelete += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDelete -= value;
                            if (onNodeDelete is null && onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete -= onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeleteProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDelete;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDeleted

                private static bool onNodeDeletedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDeleted;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDeleted
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted += onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = true;
                            }
                            onNodeDeleted += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDeleted -= value;
                            if (onNodeDeleted is null && onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted -= onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeletedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDeleted;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
            }
            public static class Allie
            {
                public static readonly Entity Entity = DeckBuilder.Model.Datastore.Model.Entities["Allie"];

                #region OnNodeLoading

                private static bool onNodeLoadingIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoading;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoading
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading += onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = true;
                            }
                            onNodeLoading += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoading -= value;
                            if (onNodeLoading is null && onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading -= onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadingProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoading;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeLoaded

                private static bool onNodeLoadedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoaded;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoaded
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded += onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = true;
                            }
                            onNodeLoaded += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoaded -= value;
                            if (onNodeLoaded is null && onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded -= onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoaded;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnBatchFinished

                private static bool onBatchFinishedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onBatchFinished;
                public static event EventHandler<Entity, NodeEventArgs> OnBatchFinished
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished += onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = true;
                            }
                            onBatchFinished += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onBatchFinished -= value;
                            if (onBatchFinished is null && onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished -= onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onBatchFinishedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onBatchFinished;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreate

                private static bool onNodeCreateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate += onNodeCreateProxy;
                                onNodeCreateIsRegistered = true;
                            }
                            onNodeCreate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreate -= value;
                            if (onNodeCreate is null && onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate -= onNodeCreateProxy;
                                onNodeCreateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreated

                private static bool onNodeCreatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated += onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = true;
                            }
                            onNodeCreated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreated -= value;
                            if (onNodeCreated is null && onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated -= onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdate

                private static bool onNodeUpdateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate += onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = true;
                            }
                            onNodeUpdate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdate -= value;
                            if (onNodeUpdate is null && onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate -= onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdated

                private static bool onNodeUpdatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated += onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = true;
                            }
                            onNodeUpdated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdated -= value;
                            if (onNodeUpdated is null && onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated -= onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDelete

                private static bool onNodeDeleteIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDelete;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDelete
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete += onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = true;
                            }
                            onNodeDelete += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDelete -= value;
                            if (onNodeDelete is null && onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete -= onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeleteProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDelete;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDeleted

                private static bool onNodeDeletedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDeleted;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDeleted
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted += onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = true;
                            }
                            onNodeDeleted += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDeleted -= value;
                            if (onNodeDeleted is null && onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted -= onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeletedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDeleted;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
            }
            public static class Boss
            {
                public static readonly Entity Entity = DeckBuilder.Model.Datastore.Model.Entities["Boss"];

                #region OnNodeLoading

                private static bool onNodeLoadingIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoading;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoading
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading += onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = true;
                            }
                            onNodeLoading += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoading -= value;
                            if (onNodeLoading is null && onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading -= onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadingProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoading;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeLoaded

                private static bool onNodeLoadedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoaded;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoaded
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded += onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = true;
                            }
                            onNodeLoaded += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoaded -= value;
                            if (onNodeLoaded is null && onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded -= onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoaded;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnBatchFinished

                private static bool onBatchFinishedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onBatchFinished;
                public static event EventHandler<Entity, NodeEventArgs> OnBatchFinished
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished += onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = true;
                            }
                            onBatchFinished += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onBatchFinished -= value;
                            if (onBatchFinished is null && onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished -= onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onBatchFinishedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onBatchFinished;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreate

                private static bool onNodeCreateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate += onNodeCreateProxy;
                                onNodeCreateIsRegistered = true;
                            }
                            onNodeCreate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreate -= value;
                            if (onNodeCreate is null && onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate -= onNodeCreateProxy;
                                onNodeCreateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreated

                private static bool onNodeCreatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated += onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = true;
                            }
                            onNodeCreated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreated -= value;
                            if (onNodeCreated is null && onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated -= onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdate

                private static bool onNodeUpdateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate += onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = true;
                            }
                            onNodeUpdate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdate -= value;
                            if (onNodeUpdate is null && onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate -= onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdated

                private static bool onNodeUpdatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated += onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = true;
                            }
                            onNodeUpdated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdated -= value;
                            if (onNodeUpdated is null && onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated -= onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDelete

                private static bool onNodeDeleteIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDelete;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDelete
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete += onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = true;
                            }
                            onNodeDelete += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDelete -= value;
                            if (onNodeDelete is null && onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete -= onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeleteProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDelete;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDeleted

                private static bool onNodeDeletedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDeleted;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDeleted
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted += onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = true;
                            }
                            onNodeDeleted += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDeleted -= value;
                            if (onNodeDeleted is null && onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted -= onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeletedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDeleted;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
            }
            public static class CardSet
            {
                public static readonly Entity Entity = DeckBuilder.Model.Datastore.Model.Entities["CardSet"];

                #region OnNodeLoading

                private static bool onNodeLoadingIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoading;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoading
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading += onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = true;
                            }
                            onNodeLoading += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoading -= value;
                            if (onNodeLoading is null && onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading -= onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadingProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoading;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeLoaded

                private static bool onNodeLoadedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoaded;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoaded
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded += onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = true;
                            }
                            onNodeLoaded += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoaded -= value;
                            if (onNodeLoaded is null && onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded -= onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoaded;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnBatchFinished

                private static bool onBatchFinishedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onBatchFinished;
                public static event EventHandler<Entity, NodeEventArgs> OnBatchFinished
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished += onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = true;
                            }
                            onBatchFinished += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onBatchFinished -= value;
                            if (onBatchFinished is null && onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished -= onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onBatchFinishedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onBatchFinished;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreate

                private static bool onNodeCreateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate += onNodeCreateProxy;
                                onNodeCreateIsRegistered = true;
                            }
                            onNodeCreate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreate -= value;
                            if (onNodeCreate is null && onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate -= onNodeCreateProxy;
                                onNodeCreateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreated

                private static bool onNodeCreatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated += onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = true;
                            }
                            onNodeCreated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreated -= value;
                            if (onNodeCreated is null && onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated -= onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdate

                private static bool onNodeUpdateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate += onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = true;
                            }
                            onNodeUpdate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdate -= value;
                            if (onNodeUpdate is null && onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate -= onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdated

                private static bool onNodeUpdatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated += onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = true;
                            }
                            onNodeUpdated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdated -= value;
                            if (onNodeUpdated is null && onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated -= onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDelete

                private static bool onNodeDeleteIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDelete;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDelete
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete += onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = true;
                            }
                            onNodeDelete += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDelete -= value;
                            if (onNodeDelete is null && onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete -= onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeleteProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDelete;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDeleted

                private static bool onNodeDeletedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDeleted;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDeleted
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted += onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = true;
                            }
                            onNodeDeleted += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDeleted -= value;
                            if (onNodeDeleted is null && onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted -= onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeletedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDeleted;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
            }
            public static class Eclipse
            {
                public static readonly Entity Entity = DeckBuilder.Model.Datastore.Model.Entities["Eclipse"];

                #region OnNodeLoading

                private static bool onNodeLoadingIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoading;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoading
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading += onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = true;
                            }
                            onNodeLoading += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoading -= value;
                            if (onNodeLoading is null && onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading -= onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadingProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoading;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeLoaded

                private static bool onNodeLoadedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoaded;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoaded
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded += onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = true;
                            }
                            onNodeLoaded += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoaded -= value;
                            if (onNodeLoaded is null && onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded -= onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoaded;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnBatchFinished

                private static bool onBatchFinishedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onBatchFinished;
                public static event EventHandler<Entity, NodeEventArgs> OnBatchFinished
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished += onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = true;
                            }
                            onBatchFinished += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onBatchFinished -= value;
                            if (onBatchFinished is null && onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished -= onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onBatchFinishedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onBatchFinished;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreate

                private static bool onNodeCreateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate += onNodeCreateProxy;
                                onNodeCreateIsRegistered = true;
                            }
                            onNodeCreate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreate -= value;
                            if (onNodeCreate is null && onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate -= onNodeCreateProxy;
                                onNodeCreateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreated

                private static bool onNodeCreatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated += onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = true;
                            }
                            onNodeCreated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreated -= value;
                            if (onNodeCreated is null && onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated -= onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdate

                private static bool onNodeUpdateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate += onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = true;
                            }
                            onNodeUpdate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdate -= value;
                            if (onNodeUpdate is null && onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate -= onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdated

                private static bool onNodeUpdatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated += onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = true;
                            }
                            onNodeUpdated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdated -= value;
                            if (onNodeUpdated is null && onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated -= onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDelete

                private static bool onNodeDeleteIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDelete;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDelete
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete += onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = true;
                            }
                            onNodeDelete += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDelete -= value;
                            if (onNodeDelete is null && onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete -= onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeleteProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDelete;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDeleted

                private static bool onNodeDeletedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDeleted;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDeleted
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted += onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = true;
                            }
                            onNodeDeleted += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDeleted -= value;
                            if (onNodeDeleted is null && onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted -= onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeletedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDeleted;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
            }
            public static class Reaction
            {
                public static readonly Entity Entity = DeckBuilder.Model.Datastore.Model.Entities["Reaction"];

                #region OnNodeLoading

                private static bool onNodeLoadingIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoading;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoading
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading += onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = true;
                            }
                            onNodeLoading += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoading -= value;
                            if (onNodeLoading is null && onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading -= onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadingProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoading;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeLoaded

                private static bool onNodeLoadedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoaded;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoaded
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded += onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = true;
                            }
                            onNodeLoaded += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoaded -= value;
                            if (onNodeLoaded is null && onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded -= onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoaded;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnBatchFinished

                private static bool onBatchFinishedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onBatchFinished;
                public static event EventHandler<Entity, NodeEventArgs> OnBatchFinished
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished += onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = true;
                            }
                            onBatchFinished += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onBatchFinished -= value;
                            if (onBatchFinished is null && onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished -= onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onBatchFinishedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onBatchFinished;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreate

                private static bool onNodeCreateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate += onNodeCreateProxy;
                                onNodeCreateIsRegistered = true;
                            }
                            onNodeCreate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreate -= value;
                            if (onNodeCreate is null && onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate -= onNodeCreateProxy;
                                onNodeCreateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreated

                private static bool onNodeCreatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated += onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = true;
                            }
                            onNodeCreated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreated -= value;
                            if (onNodeCreated is null && onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated -= onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdate

                private static bool onNodeUpdateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate += onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = true;
                            }
                            onNodeUpdate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdate -= value;
                            if (onNodeUpdate is null && onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate -= onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdated

                private static bool onNodeUpdatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated += onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = true;
                            }
                            onNodeUpdated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdated -= value;
                            if (onNodeUpdated is null && onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated -= onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDelete

                private static bool onNodeDeleteIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDelete;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDelete
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete += onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = true;
                            }
                            onNodeDelete += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDelete -= value;
                            if (onNodeDelete is null && onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete -= onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeleteProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDelete;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDeleted

                private static bool onNodeDeletedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDeleted;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDeleted
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted += onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = true;
                            }
                            onNodeDeleted += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDeleted -= value;
                            if (onNodeDeleted is null && onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted -= onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeletedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDeleted;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
            }
            public static class Sbire
            {
                public static readonly Entity Entity = DeckBuilder.Model.Datastore.Model.Entities["Sbire"];

                #region OnNodeLoading

                private static bool onNodeLoadingIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoading;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoading
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading += onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = true;
                            }
                            onNodeLoading += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoading -= value;
                            if (onNodeLoading is null && onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading -= onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadingProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoading;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeLoaded

                private static bool onNodeLoadedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoaded;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoaded
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded += onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = true;
                            }
                            onNodeLoaded += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoaded -= value;
                            if (onNodeLoaded is null && onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded -= onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoaded;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnBatchFinished

                private static bool onBatchFinishedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onBatchFinished;
                public static event EventHandler<Entity, NodeEventArgs> OnBatchFinished
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished += onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = true;
                            }
                            onBatchFinished += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onBatchFinished -= value;
                            if (onBatchFinished is null && onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished -= onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onBatchFinishedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onBatchFinished;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreate

                private static bool onNodeCreateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate += onNodeCreateProxy;
                                onNodeCreateIsRegistered = true;
                            }
                            onNodeCreate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreate -= value;
                            if (onNodeCreate is null && onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate -= onNodeCreateProxy;
                                onNodeCreateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreated

                private static bool onNodeCreatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated += onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = true;
                            }
                            onNodeCreated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreated -= value;
                            if (onNodeCreated is null && onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated -= onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdate

                private static bool onNodeUpdateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate += onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = true;
                            }
                            onNodeUpdate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdate -= value;
                            if (onNodeUpdate is null && onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate -= onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdated

                private static bool onNodeUpdatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated += onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = true;
                            }
                            onNodeUpdated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdated -= value;
                            if (onNodeUpdated is null && onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated -= onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDelete

                private static bool onNodeDeleteIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDelete;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDelete
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete += onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = true;
                            }
                            onNodeDelete += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDelete -= value;
                            if (onNodeDelete is null && onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete -= onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeleteProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDelete;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDeleted

                private static bool onNodeDeletedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDeleted;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDeleted
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted += onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = true;
                            }
                            onNodeDeleted += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDeleted -= value;
                            if (onNodeDeleted is null && onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted -= onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeletedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDeleted;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
            }
            public static class SbireUnique
            {
                public static readonly Entity Entity = DeckBuilder.Model.Datastore.Model.Entities["SbireUnique"];

                #region OnNodeLoading

                private static bool onNodeLoadingIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoading;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoading
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading += onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = true;
                            }
                            onNodeLoading += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoading -= value;
                            if (onNodeLoading is null && onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading -= onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadingProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoading;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeLoaded

                private static bool onNodeLoadedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoaded;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoaded
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded += onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = true;
                            }
                            onNodeLoaded += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoaded -= value;
                            if (onNodeLoaded is null && onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded -= onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoaded;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnBatchFinished

                private static bool onBatchFinishedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onBatchFinished;
                public static event EventHandler<Entity, NodeEventArgs> OnBatchFinished
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished += onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = true;
                            }
                            onBatchFinished += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onBatchFinished -= value;
                            if (onBatchFinished is null && onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished -= onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onBatchFinishedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onBatchFinished;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreate

                private static bool onNodeCreateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate += onNodeCreateProxy;
                                onNodeCreateIsRegistered = true;
                            }
                            onNodeCreate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreate -= value;
                            if (onNodeCreate is null && onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate -= onNodeCreateProxy;
                                onNodeCreateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreated

                private static bool onNodeCreatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated += onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = true;
                            }
                            onNodeCreated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreated -= value;
                            if (onNodeCreated is null && onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated -= onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdate

                private static bool onNodeUpdateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate += onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = true;
                            }
                            onNodeUpdate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdate -= value;
                            if (onNodeUpdate is null && onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate -= onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdated

                private static bool onNodeUpdatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated += onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = true;
                            }
                            onNodeUpdated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdated -= value;
                            if (onNodeUpdated is null && onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated -= onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDelete

                private static bool onNodeDeleteIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDelete;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDelete
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete += onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = true;
                            }
                            onNodeDelete += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDelete -= value;
                            if (onNodeDelete is null && onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete -= onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeleteProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDelete;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDeleted

                private static bool onNodeDeletedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDeleted;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDeleted
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted += onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = true;
                            }
                            onNodeDeleted += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDeleted -= value;
                            if (onNodeDeleted is null && onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted -= onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeletedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDeleted;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
            }
            public static class Token
            {
                public static readonly Entity Entity = DeckBuilder.Model.Datastore.Model.Entities["Token"];

                #region OnNodeLoading

                private static bool onNodeLoadingIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoading;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoading
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading += onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = true;
                            }
                            onNodeLoading += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoading -= value;
                            if (onNodeLoading is null && onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading -= onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadingProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoading;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeLoaded

                private static bool onNodeLoadedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoaded;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoaded
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded += onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = true;
                            }
                            onNodeLoaded += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoaded -= value;
                            if (onNodeLoaded is null && onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded -= onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoaded;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnBatchFinished

                private static bool onBatchFinishedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onBatchFinished;
                public static event EventHandler<Entity, NodeEventArgs> OnBatchFinished
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished += onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = true;
                            }
                            onBatchFinished += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onBatchFinished -= value;
                            if (onBatchFinished is null && onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished -= onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onBatchFinishedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onBatchFinished;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreate

                private static bool onNodeCreateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate += onNodeCreateProxy;
                                onNodeCreateIsRegistered = true;
                            }
                            onNodeCreate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreate -= value;
                            if (onNodeCreate is null && onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate -= onNodeCreateProxy;
                                onNodeCreateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreated

                private static bool onNodeCreatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated += onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = true;
                            }
                            onNodeCreated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreated -= value;
                            if (onNodeCreated is null && onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated -= onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdate

                private static bool onNodeUpdateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate += onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = true;
                            }
                            onNodeUpdate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdate -= value;
                            if (onNodeUpdate is null && onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate -= onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdated

                private static bool onNodeUpdatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated += onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = true;
                            }
                            onNodeUpdated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdated -= value;
                            if (onNodeUpdated is null && onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated -= onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDelete

                private static bool onNodeDeleteIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDelete;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDelete
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete += onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = true;
                            }
                            onNodeDelete += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDelete -= value;
                            if (onNodeDelete is null && onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete -= onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeleteProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDelete;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDeleted

                private static bool onNodeDeletedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDeleted;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDeleted
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted += onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = true;
                            }
                            onNodeDeleted += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDeleted -= value;
                            if (onNodeDeleted is null && onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted -= onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeletedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDeleted;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
            }
            public static class Valise
            {
                public static readonly Entity Entity = DeckBuilder.Model.Datastore.Model.Entities["Valise"];

                #region OnNodeLoading

                private static bool onNodeLoadingIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoading;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoading
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading += onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = true;
                            }
                            onNodeLoading += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoading -= value;
                            if (onNodeLoading is null && onNodeLoadingIsRegistered)
                            {
                                Entity.Events.OnNodeLoading -= onNodeLoadingProxy;
                                onNodeLoadingIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadingProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoading;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeLoaded

                private static bool onNodeLoadedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeLoaded;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeLoaded
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded += onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = true;
                            }
                            onNodeLoaded += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeLoaded -= value;
                            if (onNodeLoaded is null && onNodeLoadedIsRegistered)
                            {
                                Entity.Events.OnNodeLoaded -= onNodeLoadedProxy;
                                onNodeLoadedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeLoadedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeLoaded;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnBatchFinished

                private static bool onBatchFinishedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onBatchFinished;
                public static event EventHandler<Entity, NodeEventArgs> OnBatchFinished
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished += onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = true;
                            }
                            onBatchFinished += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onBatchFinished -= value;
                            if (onBatchFinished is null && onBatchFinishedIsRegistered)
                            {
                                Entity.Events.OnBatchFinished -= onBatchFinishedProxy;
                                onBatchFinishedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onBatchFinishedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onBatchFinished;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreate

                private static bool onNodeCreateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate += onNodeCreateProxy;
                                onNodeCreateIsRegistered = true;
                            }
                            onNodeCreate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreate -= value;
                            if (onNodeCreate is null && onNodeCreateIsRegistered)
                            {
                                Entity.Events.OnNodeCreate -= onNodeCreateProxy;
                                onNodeCreateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeCreated

                private static bool onNodeCreatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeCreated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeCreated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated += onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = true;
                            }
                            onNodeCreated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeCreated -= value;
                            if (onNodeCreated is null && onNodeCreatedIsRegistered)
                            {
                                Entity.Events.OnNodeCreated -= onNodeCreatedProxy;
                                onNodeCreatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeCreatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeCreated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdate

                private static bool onNodeUpdateIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdate;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdate
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate += onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = true;
                            }
                            onNodeUpdate += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdate -= value;
                            if (onNodeUpdate is null && onNodeUpdateIsRegistered)
                            {
                                Entity.Events.OnNodeUpdate -= onNodeUpdateProxy;
                                onNodeUpdateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdateProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdate;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeUpdated

                private static bool onNodeUpdatedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeUpdated;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeUpdated
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated += onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = true;
                            }
                            onNodeUpdated += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeUpdated -= value;
                            if (onNodeUpdated is null && onNodeUpdatedIsRegistered)
                            {
                                Entity.Events.OnNodeUpdated -= onNodeUpdatedProxy;
                                onNodeUpdatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeUpdatedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeUpdated;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDelete

                private static bool onNodeDeleteIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDelete;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDelete
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete += onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = true;
                            }
                            onNodeDelete += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDelete -= value;
                            if (onNodeDelete is null && onNodeDeleteIsRegistered)
                            {
                                Entity.Events.OnNodeDelete -= onNodeDeleteProxy;
                                onNodeDeleteIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeleteProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDelete;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
                #region OnNodeDeleted

                private static bool onNodeDeletedIsRegistered = false;

                private static event EventHandler<Entity, NodeEventArgs> onNodeDeleted;
                public static event EventHandler<Entity, NodeEventArgs> OnNodeDeleted
                {
                    add
                    {
                        lock (Entity)
                        {
                            if (!onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted += onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = true;
                            }
                            onNodeDeleted += value;
                        }
                    }
                    remove
                    {
                        lock (Entity)
                        {
                            onNodeDeleted -= value;
                            if (onNodeDeleted is null && onNodeDeletedIsRegistered)
                            {
                                Entity.Events.OnNodeDeleted -= onNodeDeletedProxy;
                                onNodeDeletedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onNodeDeletedProxy(object sender, NodeEventArgs args)
                {
                    EventHandler<Entity, NodeEventArgs> handler = onNodeDeleted;
                    if (handler is not null)
                        handler.Invoke((Entity)sender, args);
                }

                #endregion
            }
        }
        public static class Relationships
        {
            public static class ECLIPSING
            {
                public static readonly Relationship Relationship = DeckBuilder.Model.Datastore.Model.Relations["ECLIPSING"];

                #region OnRelationCreate

                private static bool onRelationCreateIsRegistered = false;

                private static event EventHandler<Relationship, RelationshipEventArgs> onRelationCreate;
                public static event EventHandler<Relationship, RelationshipEventArgs> OnRelationCreate
                {
                    add
                    {
                        lock (Relationship)
                        {
                            if (!onRelationCreateIsRegistered)
                            {
                                Relationship.Events.OnRelationCreate += onRelationCreateProxy;
                                onRelationCreateIsRegistered = true;
                            }
                            onRelationCreate += value;
                        }
                    }
                    remove
                    {
                        lock (Relationship)
                        {
                            onRelationCreate -= value;
                            if (onRelationCreate is null && onRelationCreateIsRegistered)
                            {
                                Relationship.Events.OnRelationCreate -= onRelationCreateProxy;
                                onRelationCreateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onRelationCreateProxy(object sender, RelationshipEventArgs args)
                {
                    EventHandler<Relationship, RelationshipEventArgs> handler = onRelationCreate;
                    if (handler is not null)
                        handler.Invoke((Relationship)sender, args);
                }

                #endregion
                #region OnRelationCreated

                private static bool onRelationCreatedIsRegistered = false;

                private static event EventHandler<Relationship, RelationshipEventArgs> onRelationCreated;
                public static event EventHandler<Relationship, RelationshipEventArgs> OnRelationCreated
                {
                    add
                    {
                        lock (Relationship)
                        {
                            if (!onRelationCreatedIsRegistered)
                            {
                                Relationship.Events.OnRelationCreated += onRelationCreatedProxy;
                                onRelationCreatedIsRegistered = true;
                            }
                            onRelationCreated += value;
                        }
                    }
                    remove
                    {
                        lock (Relationship)
                        {
                            onRelationCreated -= value;
                            if (onRelationCreated is null && onRelationCreatedIsRegistered)
                            {
                                Relationship.Events.OnRelationCreated -= onRelationCreatedProxy;
                                onRelationCreatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onRelationCreatedProxy(object sender, RelationshipEventArgs args)
                {
                    EventHandler<Relationship, RelationshipEventArgs> handler = onRelationCreated;
                    if (handler is not null)
                        handler.Invoke((Relationship)sender, args);
                }

                #endregion
                #region OnRelationDelete

                private static bool onRelationDeleteIsRegistered = false;

                private static event EventHandler<Relationship, RelationshipEventArgs> onRelationDelete;
                public static event EventHandler<Relationship, RelationshipEventArgs> OnRelationDelete
                {
                    add
                    {
                        lock (Relationship)
                        {
                            if (!onRelationDeleteIsRegistered)
                            {
                                Relationship.Events.OnRelationDelete += onRelationDeleteProxy;
                                onRelationDeleteIsRegistered = true;
                            }
                            onRelationDelete += value;
                        }
                    }
                    remove
                    {
                        lock (Relationship)
                        {
                            onRelationDelete -= value;
                            if (onRelationDelete is null && onRelationDeleteIsRegistered)
                            {
                                Relationship.Events.OnRelationDelete -= onRelationDeleteProxy;
                                onRelationDeleteIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onRelationDeleteProxy(object sender, RelationshipEventArgs args)
                {
                    EventHandler<Relationship, RelationshipEventArgs> handler = onRelationDelete;
                    if (handler is not null)
                        handler.Invoke((Relationship)sender, args);
                }

                #endregion
                #region OnRelationDeleted

                private static bool onRelationDeletedIsRegistered = false;

                private static event EventHandler<Relationship, RelationshipEventArgs> onRelationDeleted;
                public static event EventHandler<Relationship, RelationshipEventArgs> OnRelationDeleted
                {
                    add
                    {
                        lock (Relationship)
                        {
                            if (!onRelationDeletedIsRegistered)
                            {
                                Relationship.Events.OnRelationDeleted += onRelationDeletedProxy;
                                onRelationDeletedIsRegistered = true;
                            }
                            onRelationDeleted += value;
                        }
                    }
                    remove
                    {
                        lock (Relationship)
                        {
                            onRelationDeleted -= value;
                            if (onRelationDeleted is null && onRelationDeletedIsRegistered)
                            {
                                Relationship.Events.OnRelationDeleted -= onRelationDeletedProxy;
                                onRelationDeletedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onRelationDeletedProxy(object sender, RelationshipEventArgs args)
                {
                    EventHandler<Relationship, RelationshipEventArgs> handler = onRelationDeleted;
                    if (handler is not null)
                        handler.Invoke((Relationship)sender, args);
                }

                #endregion
            }
            public static class HAS_CARD
            {
                public static readonly Relationship Relationship = DeckBuilder.Model.Datastore.Model.Relations["HAS_CARD"];

                #region OnRelationCreate

                private static bool onRelationCreateIsRegistered = false;

                private static event EventHandler<Relationship, RelationshipEventArgs> onRelationCreate;
                public static event EventHandler<Relationship, RelationshipEventArgs> OnRelationCreate
                {
                    add
                    {
                        lock (Relationship)
                        {
                            if (!onRelationCreateIsRegistered)
                            {
                                Relationship.Events.OnRelationCreate += onRelationCreateProxy;
                                onRelationCreateIsRegistered = true;
                            }
                            onRelationCreate += value;
                        }
                    }
                    remove
                    {
                        lock (Relationship)
                        {
                            onRelationCreate -= value;
                            if (onRelationCreate is null && onRelationCreateIsRegistered)
                            {
                                Relationship.Events.OnRelationCreate -= onRelationCreateProxy;
                                onRelationCreateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onRelationCreateProxy(object sender, RelationshipEventArgs args)
                {
                    EventHandler<Relationship, RelationshipEventArgs> handler = onRelationCreate;
                    if (handler is not null)
                        handler.Invoke((Relationship)sender, args);
                }

                #endregion
                #region OnRelationCreated

                private static bool onRelationCreatedIsRegistered = false;

                private static event EventHandler<Relationship, RelationshipEventArgs> onRelationCreated;
                public static event EventHandler<Relationship, RelationshipEventArgs> OnRelationCreated
                {
                    add
                    {
                        lock (Relationship)
                        {
                            if (!onRelationCreatedIsRegistered)
                            {
                                Relationship.Events.OnRelationCreated += onRelationCreatedProxy;
                                onRelationCreatedIsRegistered = true;
                            }
                            onRelationCreated += value;
                        }
                    }
                    remove
                    {
                        lock (Relationship)
                        {
                            onRelationCreated -= value;
                            if (onRelationCreated is null && onRelationCreatedIsRegistered)
                            {
                                Relationship.Events.OnRelationCreated -= onRelationCreatedProxy;
                                onRelationCreatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onRelationCreatedProxy(object sender, RelationshipEventArgs args)
                {
                    EventHandler<Relationship, RelationshipEventArgs> handler = onRelationCreated;
                    if (handler is not null)
                        handler.Invoke((Relationship)sender, args);
                }

                #endregion
                #region OnRelationDelete

                private static bool onRelationDeleteIsRegistered = false;

                private static event EventHandler<Relationship, RelationshipEventArgs> onRelationDelete;
                public static event EventHandler<Relationship, RelationshipEventArgs> OnRelationDelete
                {
                    add
                    {
                        lock (Relationship)
                        {
                            if (!onRelationDeleteIsRegistered)
                            {
                                Relationship.Events.OnRelationDelete += onRelationDeleteProxy;
                                onRelationDeleteIsRegistered = true;
                            }
                            onRelationDelete += value;
                        }
                    }
                    remove
                    {
                        lock (Relationship)
                        {
                            onRelationDelete -= value;
                            if (onRelationDelete is null && onRelationDeleteIsRegistered)
                            {
                                Relationship.Events.OnRelationDelete -= onRelationDeleteProxy;
                                onRelationDeleteIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onRelationDeleteProxy(object sender, RelationshipEventArgs args)
                {
                    EventHandler<Relationship, RelationshipEventArgs> handler = onRelationDelete;
                    if (handler is not null)
                        handler.Invoke((Relationship)sender, args);
                }

                #endregion
                #region OnRelationDeleted

                private static bool onRelationDeletedIsRegistered = false;

                private static event EventHandler<Relationship, RelationshipEventArgs> onRelationDeleted;
                public static event EventHandler<Relationship, RelationshipEventArgs> OnRelationDeleted
                {
                    add
                    {
                        lock (Relationship)
                        {
                            if (!onRelationDeletedIsRegistered)
                            {
                                Relationship.Events.OnRelationDeleted += onRelationDeletedProxy;
                                onRelationDeletedIsRegistered = true;
                            }
                            onRelationDeleted += value;
                        }
                    }
                    remove
                    {
                        lock (Relationship)
                        {
                            onRelationDeleted -= value;
                            if (onRelationDeleted is null && onRelationDeletedIsRegistered)
                            {
                                Relationship.Events.OnRelationDeleted -= onRelationDeletedProxy;
                                onRelationDeletedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onRelationDeletedProxy(object sender, RelationshipEventArgs args)
                {
                    EventHandler<Relationship, RelationshipEventArgs> handler = onRelationDeleted;
                    if (handler is not null)
                        handler.Invoke((Relationship)sender, args);
                }

                #endregion
            }
            public static class HAS_COST_TOKEN
            {
                public static readonly Relationship Relationship = DeckBuilder.Model.Datastore.Model.Relations["HAS_COST_TOKEN"];

                #region OnRelationCreate

                private static bool onRelationCreateIsRegistered = false;

                private static event EventHandler<Relationship, RelationshipEventArgs> onRelationCreate;
                public static event EventHandler<Relationship, RelationshipEventArgs> OnRelationCreate
                {
                    add
                    {
                        lock (Relationship)
                        {
                            if (!onRelationCreateIsRegistered)
                            {
                                Relationship.Events.OnRelationCreate += onRelationCreateProxy;
                                onRelationCreateIsRegistered = true;
                            }
                            onRelationCreate += value;
                        }
                    }
                    remove
                    {
                        lock (Relationship)
                        {
                            onRelationCreate -= value;
                            if (onRelationCreate is null && onRelationCreateIsRegistered)
                            {
                                Relationship.Events.OnRelationCreate -= onRelationCreateProxy;
                                onRelationCreateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onRelationCreateProxy(object sender, RelationshipEventArgs args)
                {
                    EventHandler<Relationship, RelationshipEventArgs> handler = onRelationCreate;
                    if (handler is not null)
                        handler.Invoke((Relationship)sender, args);
                }

                #endregion
                #region OnRelationCreated

                private static bool onRelationCreatedIsRegistered = false;

                private static event EventHandler<Relationship, RelationshipEventArgs> onRelationCreated;
                public static event EventHandler<Relationship, RelationshipEventArgs> OnRelationCreated
                {
                    add
                    {
                        lock (Relationship)
                        {
                            if (!onRelationCreatedIsRegistered)
                            {
                                Relationship.Events.OnRelationCreated += onRelationCreatedProxy;
                                onRelationCreatedIsRegistered = true;
                            }
                            onRelationCreated += value;
                        }
                    }
                    remove
                    {
                        lock (Relationship)
                        {
                            onRelationCreated -= value;
                            if (onRelationCreated is null && onRelationCreatedIsRegistered)
                            {
                                Relationship.Events.OnRelationCreated -= onRelationCreatedProxy;
                                onRelationCreatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onRelationCreatedProxy(object sender, RelationshipEventArgs args)
                {
                    EventHandler<Relationship, RelationshipEventArgs> handler = onRelationCreated;
                    if (handler is not null)
                        handler.Invoke((Relationship)sender, args);
                }

                #endregion
                #region OnRelationDelete

                private static bool onRelationDeleteIsRegistered = false;

                private static event EventHandler<Relationship, RelationshipEventArgs> onRelationDelete;
                public static event EventHandler<Relationship, RelationshipEventArgs> OnRelationDelete
                {
                    add
                    {
                        lock (Relationship)
                        {
                            if (!onRelationDeleteIsRegistered)
                            {
                                Relationship.Events.OnRelationDelete += onRelationDeleteProxy;
                                onRelationDeleteIsRegistered = true;
                            }
                            onRelationDelete += value;
                        }
                    }
                    remove
                    {
                        lock (Relationship)
                        {
                            onRelationDelete -= value;
                            if (onRelationDelete is null && onRelationDeleteIsRegistered)
                            {
                                Relationship.Events.OnRelationDelete -= onRelationDeleteProxy;
                                onRelationDeleteIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onRelationDeleteProxy(object sender, RelationshipEventArgs args)
                {
                    EventHandler<Relationship, RelationshipEventArgs> handler = onRelationDelete;
                    if (handler is not null)
                        handler.Invoke((Relationship)sender, args);
                }

                #endregion
                #region OnRelationDeleted

                private static bool onRelationDeletedIsRegistered = false;

                private static event EventHandler<Relationship, RelationshipEventArgs> onRelationDeleted;
                public static event EventHandler<Relationship, RelationshipEventArgs> OnRelationDeleted
                {
                    add
                    {
                        lock (Relationship)
                        {
                            if (!onRelationDeletedIsRegistered)
                            {
                                Relationship.Events.OnRelationDeleted += onRelationDeletedProxy;
                                onRelationDeletedIsRegistered = true;
                            }
                            onRelationDeleted += value;
                        }
                    }
                    remove
                    {
                        lock (Relationship)
                        {
                            onRelationDeleted -= value;
                            if (onRelationDeleted is null && onRelationDeletedIsRegistered)
                            {
                                Relationship.Events.OnRelationDeleted -= onRelationDeletedProxy;
                                onRelationDeletedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onRelationDeletedProxy(object sender, RelationshipEventArgs args)
                {
                    EventHandler<Relationship, RelationshipEventArgs> handler = onRelationDeleted;
                    if (handler is not null)
                        handler.Invoke((Relationship)sender, args);
                }

                #endregion
            }
            public static class HAS_VALUE_TOKEN
            {
                public static readonly Relationship Relationship = DeckBuilder.Model.Datastore.Model.Relations["HAS_VALUE_TOKEN"];

                #region OnRelationCreate

                private static bool onRelationCreateIsRegistered = false;

                private static event EventHandler<Relationship, RelationshipEventArgs> onRelationCreate;
                public static event EventHandler<Relationship, RelationshipEventArgs> OnRelationCreate
                {
                    add
                    {
                        lock (Relationship)
                        {
                            if (!onRelationCreateIsRegistered)
                            {
                                Relationship.Events.OnRelationCreate += onRelationCreateProxy;
                                onRelationCreateIsRegistered = true;
                            }
                            onRelationCreate += value;
                        }
                    }
                    remove
                    {
                        lock (Relationship)
                        {
                            onRelationCreate -= value;
                            if (onRelationCreate is null && onRelationCreateIsRegistered)
                            {
                                Relationship.Events.OnRelationCreate -= onRelationCreateProxy;
                                onRelationCreateIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onRelationCreateProxy(object sender, RelationshipEventArgs args)
                {
                    EventHandler<Relationship, RelationshipEventArgs> handler = onRelationCreate;
                    if (handler is not null)
                        handler.Invoke((Relationship)sender, args);
                }

                #endregion
                #region OnRelationCreated

                private static bool onRelationCreatedIsRegistered = false;

                private static event EventHandler<Relationship, RelationshipEventArgs> onRelationCreated;
                public static event EventHandler<Relationship, RelationshipEventArgs> OnRelationCreated
                {
                    add
                    {
                        lock (Relationship)
                        {
                            if (!onRelationCreatedIsRegistered)
                            {
                                Relationship.Events.OnRelationCreated += onRelationCreatedProxy;
                                onRelationCreatedIsRegistered = true;
                            }
                            onRelationCreated += value;
                        }
                    }
                    remove
                    {
                        lock (Relationship)
                        {
                            onRelationCreated -= value;
                            if (onRelationCreated is null && onRelationCreatedIsRegistered)
                            {
                                Relationship.Events.OnRelationCreated -= onRelationCreatedProxy;
                                onRelationCreatedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onRelationCreatedProxy(object sender, RelationshipEventArgs args)
                {
                    EventHandler<Relationship, RelationshipEventArgs> handler = onRelationCreated;
                    if (handler is not null)
                        handler.Invoke((Relationship)sender, args);
                }

                #endregion
                #region OnRelationDelete

                private static bool onRelationDeleteIsRegistered = false;

                private static event EventHandler<Relationship, RelationshipEventArgs> onRelationDelete;
                public static event EventHandler<Relationship, RelationshipEventArgs> OnRelationDelete
                {
                    add
                    {
                        lock (Relationship)
                        {
                            if (!onRelationDeleteIsRegistered)
                            {
                                Relationship.Events.OnRelationDelete += onRelationDeleteProxy;
                                onRelationDeleteIsRegistered = true;
                            }
                            onRelationDelete += value;
                        }
                    }
                    remove
                    {
                        lock (Relationship)
                        {
                            onRelationDelete -= value;
                            if (onRelationDelete is null && onRelationDeleteIsRegistered)
                            {
                                Relationship.Events.OnRelationDelete -= onRelationDeleteProxy;
                                onRelationDeleteIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onRelationDeleteProxy(object sender, RelationshipEventArgs args)
                {
                    EventHandler<Relationship, RelationshipEventArgs> handler = onRelationDelete;
                    if (handler is not null)
                        handler.Invoke((Relationship)sender, args);
                }

                #endregion
                #region OnRelationDeleted

                private static bool onRelationDeletedIsRegistered = false;

                private static event EventHandler<Relationship, RelationshipEventArgs> onRelationDeleted;
                public static event EventHandler<Relationship, RelationshipEventArgs> OnRelationDeleted
                {
                    add
                    {
                        lock (Relationship)
                        {
                            if (!onRelationDeletedIsRegistered)
                            {
                                Relationship.Events.OnRelationDeleted += onRelationDeletedProxy;
                                onRelationDeletedIsRegistered = true;
                            }
                            onRelationDeleted += value;
                        }
                    }
                    remove
                    {
                        lock (Relationship)
                        {
                            onRelationDeleted -= value;
                            if (onRelationDeleted is null && onRelationDeletedIsRegistered)
                            {
                                Relationship.Events.OnRelationDeleted -= onRelationDeletedProxy;
                                onRelationDeletedIsRegistered = false;
                            }
                        }
                    }
                }

                private static void onRelationDeletedProxy(object sender, RelationshipEventArgs args)
                {
                    EventHandler<Relationship, RelationshipEventArgs> handler = onRelationDeleted;
                    if (handler is not null)
                        handler.Invoke((Relationship)sender, args);
                }

                #endregion
            }
        }
    }
}
