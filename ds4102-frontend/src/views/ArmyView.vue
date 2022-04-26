<template>
    <section>
        <h2>Overview of all things in the troop</h2>
        <missions-list></missions-list>
        <soldier-list></soldier-list>
    </section>
</template>

<script>

import SoldierList from "../components/soldiers/SoldierItem.vue"
import MissionsList from "../components/missions/MissionsList.vue"

export default {
    components: {
        MissionsList,
        SoldierList
    }
}
</script>