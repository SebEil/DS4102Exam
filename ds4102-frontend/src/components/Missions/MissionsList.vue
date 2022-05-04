<template>
    <section>
        <h2 class="spacingTop">Missions</h2>
        <article class="row align d-flex justify-content-center">
        <mission-item
            class="container col p-2 text-center" v-for="(mission, i) in missions"
            :key="i"
            :missionId="mission.missionId"
            :missionName="mission.missionName"
            :missionLocation="mission.missionLocation"
            :soldiersDeployed="mission.soldiersDeployed">
            </mission-item>
        </article>
    </section>
</template>

<script>
import MissionItem from "../missions/MissionItem.vue"
import missionService from "../../services/missionService.js"




export default {
    setup(){
        const missions = missionService.getAll();

        return{
            missions
        }
    },
    components: {
        MissionItem,

    }   
}
</script>

<style>

    h2{
        color: #FFF;
    }

    .container{
        color: white;
        background: #09b568;
        border-radius: 25px;
        display: inline-block;
    }

    .spacingTop{
        padding-top: 4rem;
    }

    section{
        background-color: #191919;
    }

</style>